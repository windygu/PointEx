﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Framework.Common.Mapping;
using PointEx.Entities.Enums;

namespace PointEx.Entities.Dto
{
    public class ShopDto : IHaveCustomMappings
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string TownName { get; set; }
        public StatusEnum StatusId { get; set; }
        public string ShopStatusName
        {
            get
            {
                switch (StatusId)
                {
                    case StatusEnum.Approved:
                        return "Aprobado";
                    case StatusEnum.Rejected:
                        return "Rechazado";
                    default:
                        return "Pendiente";
                }
            }
        }
        public virtual ICollection<string> Categories { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Shop, ShopDto>()
                         .ForMember(d => d.Categories, 
                         opt => opt.MapFrom(shop => shop.ShopCategories.Select(sc => sc.Category.Name)));
        }
    }
}
