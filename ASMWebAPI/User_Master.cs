//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASMWebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Master
    {
        public int UM_I { get; set; }
        public string UM_FIRST_NAME { get; set; }
        public string UM_LAST_NAME { get; set; }
        public string UM_USER_NAME { get; set; }
        public string UM_PASSWORD { get; set; }
        public Nullable<bool> UM_ISACTIVE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<int> AGM_I { get; set; }
        public string EMAIL_ID { get; set; }
        public Nullable<int> um_login_count { get; set; }
        public Nullable<System.DateTime> um_last_login { get; set; }
        public string um_mobile_number { get; set; }
    
        public virtual App_Group_Master App_Group_Master { get; set; }
    }
}
