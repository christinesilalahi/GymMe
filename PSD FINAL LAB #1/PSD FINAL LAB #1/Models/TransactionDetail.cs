//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSD_FINAL_LAB__1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransactionDetail
    {
        public int TransactionID { get; set; }
        public int SupplementID { get; set; }
        public int Quantity { get; set; }
    
        public virtual MsSupplement MsSupplement { get; set; }
        public virtual TransactionHeader TransactionHeader { get; set; }
    }
}
