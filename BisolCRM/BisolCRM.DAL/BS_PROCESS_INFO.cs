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
    
    public partial class BS_PROCESS_INFO
    {
        public System.Guid ID { get; set; }
        public Nullable<int> USERID { get; set; }
        public string USER_GUID { get; set; }
        public string ACTION_GUID { get; set; }
        public Nullable<int> ACTION_TYPE { get; set; }
        public string OBJECT_TABLE_NAME { get; set; }
        public Nullable<int> OBJECT_ID { get; set; }
        public Nullable<int> BRANCH_ID { get; set; }
        public Nullable<System.DateTime> SP_START_TIME { get; set; }
        public Nullable<int> IS_SCHEDULED { get; set; }
    }
}
