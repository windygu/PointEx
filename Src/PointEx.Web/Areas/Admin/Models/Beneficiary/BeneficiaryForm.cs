﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Framework.Common.Mapping;
using PointEx.Entities;

namespace PointEx.Web.Models
{
    public class BeneficiaryForm : IMapFrom<Beneficiary>
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [UIHint("TownId")]
        [Display(Name = "Localidad")]
        [Required]
        public int TownId { get; set; }

        [Required]
        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }

        [UIHint("EducationalInstitutionId")]
        [Display(Name = "Establecimiento Educativo")]
        public int? EducationalInstitutionId { get; set; }

        [Display(Name = "Informacion de usuario")]
        public RegisterViewModel RegisterViewModel { get; set; }
        
        public Beneficiary ToBeneficiary()
        {
            var beneficiary = Mapper.Map<BeneficiaryForm, Beneficiary>(this);
            return beneficiary;
        }

        public static BeneficiaryForm FromBeneficiary(Beneficiary beneficiary)
        {
            var form = Mapper.Map<Beneficiary, BeneficiaryForm>(beneficiary);
            return form;
        }
    }
}