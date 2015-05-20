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
    
    public partial class Shop
    {
        public Shop()
        {
            this.Purchases = new HashSet<Purchase>();
            this.Benefits = new HashSet<Benefit>();
            this.ShopCategories = new HashSet<ShopCategory>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int TownId { get; set; }
        public string UserId { get; set; }
        public System.Data.Entity.Spatial.DbGeography Location { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Benefit> Benefits { get; set; }
        public virtual Town Town { get; set; }
        public virtual ICollection<ShopCategory> ShopCategories { get; set; }
        public virtual User User { get; set; }
    }
}
