//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PointEx.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Benefit
    {
        public Benefit()
        {
            this.Purchases = new HashSet<Purchase>();
            this.BenefitFiles = new HashSet<BenefitFile>();
            this.BenefitBranchOffices = new HashSet<BenefitBranchOffice>();
            this.SectionItems = new HashSet<SectionItem>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> DiscountPercentage { get; set; }
        public Nullable<decimal> DiscountPercentageCeiling { get; set; }
        public int ShopId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public System.DateTime DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<PointEx.Entities.Enums.BenefitTypesEnum> BenefitTypeId { get; set; }
    
        public virtual Shop Shop { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<BenefitFile> BenefitFiles { get; set; }
        public virtual ICollection<BenefitBranchOffice> BenefitBranchOffices { get; set; }
        public virtual ICollection<SectionItem> SectionItems { get; set; }
        public virtual BenefitType BenefitType { get; set; }
    }
}
