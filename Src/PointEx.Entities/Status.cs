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
    
    public partial class Status
    {
        public Status()
        {
            this.Benefits = new HashSet<Benefit>();
            this.Shops = new HashSet<Shop>();
            this.Beneficiaries = new HashSet<Beneficiary>();
        }
    
        public PointEx.Entities.Enums.StatusEnum Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Benefit> Benefits { get; set; }
        public virtual ICollection<Shop> Shops { get; set; }
        public virtual ICollection<Beneficiary> Beneficiaries { get; set; }
    }
}