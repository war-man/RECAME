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
    
    public partial class TAWDBBILLINGCYCLE
    {
        public int ID { get; set; }
        public Nullable<int> BILLINGCYCLEPLAN { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> DESTROYDATE { get; set; }
        public Nullable<System.DateTime> LASTMODIFIED { get; set; }
        public Nullable<int> LISTINDEX { get; set; }
        public string NAME { get; set; }
        public Nullable<int> TERRITORY { get; set; }
    }
}
