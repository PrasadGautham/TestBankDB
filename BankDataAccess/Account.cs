//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public long Number { get; set; }
        public double Balance { get; set; }
        public long CustomerID { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
