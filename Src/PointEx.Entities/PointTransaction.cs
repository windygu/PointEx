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
    
    public partial class PointTransaction
    {
        public Nullable<int> Id { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public string Description { get; set; }
        public Nullable<int> Debit { get; set; }
        public Nullable<int> Credit { get; set; }
    }
}
