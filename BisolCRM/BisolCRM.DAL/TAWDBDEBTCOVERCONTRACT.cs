//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BisolCRM.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TAWDBDEBTCOVERCONTRACT
    {
        public int ID { get; set; }
        public Nullable<int> CONTRACT { get; set; }
        public string COUNTERNUMBER { get; set; }
        public string COUNTERSTATMENTNUMBER { get; set; }
        public Nullable<System.DateTime> EVENTDATE { get; set; }
        public Nullable<short> ISSCHEDULED { get; set; }
        public Nullable<System.DateTime> LASTMODIFIED { get; set; }
        public Nullable<decimal> PAYMENT { get; set; }
        public string PAYMENTINVOICENUMBER { get; set; }
        public Nullable<short> REGISTERSERTIFICATE { get; set; }
        public string SCHEDULENUMBER { get; set; }
        public string TECHNICNUMBER { get; set; }
    }
}
