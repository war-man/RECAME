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
    
    public partial class TAWDBINSPECTION
    {
        public int ID { get; set; }
        public Nullable<int> CONTRACT { get; set; }
        public Nullable<short> COUNTERCHANGED { get; set; }
        public Nullable<short> COUNTERTROUBLE { get; set; }
        public Nullable<short> COUNTERTROUBLESTATMENT { get; set; }
        public Nullable<short> DETACHED { get; set; }
        public Nullable<int> EMPLOYEE1 { get; set; }
        public Nullable<int> EMPLOYEE2 { get; set; }
        public Nullable<int> EMPLOYEE3 { get; set; }
        public Nullable<System.DateTime> EVENTDATE { get; set; }
        public Nullable<short> ILLEGALJOINING { get; set; }
        public Nullable<short> ILLEGALSTATMENT { get; set; }
        public Nullable<System.DateTime> LASTMODIFIED { get; set; }
        public Nullable<short> LEGALIZATED { get; set; }
        public Nullable<short> RESTAMPED { get; set; }
        public Nullable<short> STAMPTROUBLE { get; set; }
        public Nullable<short> STAMPTROUBLESTATMENT { get; set; }
        public Nullable<decimal> INDICATION1 { get; set; }
        public Nullable<decimal> INDICATION2 { get; set; }
        public Nullable<decimal> INDICATION3 { get; set; }
    }
}
