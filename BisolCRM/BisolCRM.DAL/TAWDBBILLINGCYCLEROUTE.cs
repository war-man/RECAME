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
    
    public partial class TAWDBBILLINGCYCLEROUTE
    {
        public int ID { get; set; }
        public Nullable<int> BILLINGCYCLE { get; set; }
        public Nullable<short> COUNTERSONLY { get; set; }
        public Nullable<System.DateTime> EVENTDATE { get; set; }
        public Nullable<System.DateTime> LASTMODIFIED { get; set; }
        public Nullable<int> PREVROUTE { get; set; }
        public Nullable<short> VISITED { get; set; }
        public Nullable<short> ISCALCAVERAGED { get; set; }
        public Nullable<short> REPORT_COUNTER_NUMBER { get; set; }
        public Nullable<short> REPORT_COUNTER_STAMPNUMBER { get; set; }
        public Nullable<short> REPORT_INDICATION { get; set; }
    }
}
