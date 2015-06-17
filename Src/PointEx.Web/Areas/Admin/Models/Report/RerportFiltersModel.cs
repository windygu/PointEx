﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Web.Routing;
using Framework.Report;
using PointEx.Web.Models.List;

namespace PointEx.Web.Models
{
    public class ReportFiltersModel : FilterBaseModel
    {
        public ReportFiltersModel()
        {
            From = DateTime.Now.Date.AddMonths(-1);
            To = DateTime.Now.Date;
        }

        [Display(Name = "Desde")]
        [DataType(DataType.Date)]
        public DateTime? From { get; set; }

        [Display(Name = "Hasta")]
        [DataType(DataType.Date)]
        public DateTime? To { get; set; }

        public ReportTypeEnum ReportType { get; set; }

        [UIHint("ShopId")]
        [Display(Name = @"Comercio")]
        public int? ShopId { get; set; }

        [UIHint("EducationalInstitutionId")]
        [Display(Name = "Establecimiento Educativo")]
        public int? EducationalInstitutionId { get; set; }

        public RouteValueDictionary GetRouteValues(ReportTypeEnum rerportType = ReportTypeEnum.Pdf)
        {
            var routeValues = new RouteValueDictionary();
            routeValues.Add("ReportType", rerportType);
            routeValues.Add("From", this.From.HasValue ? this.From.Value.ToShortDateString() : null);
            routeValues.Add("To", this.To.HasValue ? this.To.Value.ToShortDateString() : null);
            routeValues.Add("EducationalInstitutionId", this.EducationalInstitutionId);
            routeValues.Add("ShopId", this.ShopId);
            return routeValues;
        }
    }
}