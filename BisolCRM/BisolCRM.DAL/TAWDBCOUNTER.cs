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
    
    public partial class TAWDBCOUNTER
    {
        public int ID { get; set; }
        public string CNTTYPE { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> DESTROYDATE { get; set; }
        public Nullable<System.DateTime> LASTCHECK { get; set; }
        public Nullable<System.DateTime> LASTMODIFIED { get; set; }
        public Nullable<short> LAUNCHYEAR { get; set; }
        public string NUMBER { get; set; }
        public Nullable<int> POINT { get; set; }
        public Nullable<int> SIGNSNUMBER { get; set; }
        public string STAMPNUMBER { get; set; }
        public string LASTCHECKNUMBER { get; set; }
        public Nullable<short> COUNTERSTATUS { get; set; }
        public Nullable<System.DateTime> HOLOGRAPHSTAMPDATE { get; set; }
        public string HOLOGRAPHSTAMP { get; set; }
        public Nullable<int> OWNER { get; set; }
        public Nullable<int> POSITION { get; set; }
        public Nullable<decimal> DIAMETER { get; set; }
        public Nullable<int> CATEGORY { get; set; }
        public Nullable<double> LONGITUDE { get; set; }
        public Nullable<double> LATITUDE { get; set; }
        public string CENTER_GEOM { get; set; }
    }
}
