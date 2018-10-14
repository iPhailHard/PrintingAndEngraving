//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Printing_and_Engraving_Site
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public int ItemID { get; set; }
        public decimal TotalPrice { get; set; }
        public Nullable<bool> IsPaid { get; set; }
        public Nullable<bool> IsCOD { get; set; }
        public string OrderNote { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual User User { get; set; }
    }
}