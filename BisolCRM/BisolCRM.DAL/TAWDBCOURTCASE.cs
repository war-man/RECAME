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
    
    public partial class TAWDBCOURTCASE
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> AGREEMENTCONTRACTDATE { get; set; }
        public Nullable<int> AGREEMENTCONTRACTSCHEDULE { get; set; }
        public Nullable<int> CONTRACT { get; set; }
        public Nullable<System.DateTime> EVENTDATE { get; set; }
        public Nullable<System.DateTime> EXECUTIVEACTIONDATE { get; set; }
        public Nullable<short> EXECUTIVEACTIONKIND { get; set; }
        public string EXECUTIVEACTIONNUMBER { get; set; }
        public Nullable<short> ISAGREEMENTCONTRACT { get; set; }
        public Nullable<short> ISEXECUTIVEACTION { get; set; }
        public Nullable<short> ISPAYMENTORDER { get; set; }
        public Nullable<short> ISSUITTRANSACTION { get; set; }
        public Nullable<System.DateTime> LASTMODIFIED { get; set; }
        public Nullable<decimal> PAYMENTORDERAMOUNT { get; set; }
        public Nullable<System.DateTime> PAYMENTORDERDATE { get; set; }
        public string PAYMENTORDEREXECUTIVEACT { get; set; }
        public Nullable<decimal> SUITTRANSACTIONAMOUNT { get; set; }
        public string SUITTRANSACTIONCASENUMBER { get; set; }
        public Nullable<System.DateTime> SUITTRANSACTIONDATE { get; set; }
        public Nullable<short> SUITTRANSACTIONKIND { get; set; }
        public Nullable<decimal> SUITTRANSACTIONSTAMOUNT { get; set; }
        public string SUITTRANSACTIONSTNUMBER { get; set; }
        public Nullable<decimal> TAXPYM { get; set; }
        public Nullable<System.DateTime> TAXPYMCOMPENSATIONDATE { get; set; }
        public Nullable<decimal> TAXPYMCOMPENSATIONPYM { get; set; }
        public Nullable<System.DateTime> TAXPYMDATE { get; set; }
    }
}
