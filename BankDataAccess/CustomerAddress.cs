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
    
    public partial class CustomerAddress
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public long AddressID { get; set; }
        public Nullable<long> CustomerID { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
