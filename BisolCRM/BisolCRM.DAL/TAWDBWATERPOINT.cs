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
    
    public partial class TAWDBWATERPOINT
    {
        public int ID { get; set; }
        public string BASIN { get; set; }
        public Nullable<short> CALCMETHOD { get; set; }
        public Nullable<int> CONTRACT { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> DESTROYDATE { get; set; }
        public Nullable<short> HASNODRAINAGE { get; set; }
        public Nullable<short> IRRIGATION { get; set; }
        public Nullable<System.DateTime> LASTMODIFIED { get; set; }
        public Nullable<int> MAPINDEX { get; set; }
        public string MEMO { get; set; }
        public Nullable<short> NOTSUPPLYDAYS { get; set; }
        public Nullable<int> PARENT { get; set; }
        public Nullable<decimal> SUPPLYTIME { get; set; }
        public Nullable<decimal> TARIFF { get; set; }
        public Nullable<double> TUBEDIAMETER { get; set; }
        public string STAMPNUMBER { get; set; }
        public Nullable<int> SUPPLYSCHEDULE1 { get; set; }
        public Nullable<int> SUPPLYSCHEDULE2 { get; set; }
        public Nullable<decimal> IRRIGATIONTARIFF { get; set; }
        public Nullable<decimal> IRRIGATIONLIMIT { get; set; }
        public Nullable<int> IRRIGATIONSTARTMONTH { get; set; }
        public Nullable<int> IRRIGATIONENDMONTH { get; set; }
    }
}
