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
    
    public partial class TaxiwayInspectionChecklist
    {
        public int T_ID { get; set; }
        public Nullable<int> TIC_ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string TWY_Inspected { get; set; }
        public Nullable<System.TimeSpan> Inspection_Time { get; set; }
        public string Acceptability { get; set; }
        public string Action_Taken { get; set; }
        public string NC_Filed_Ref_No { get; set; }
        public string Department_Name { get; set; }
        public string Person_Name { get; set; }
        public string Other_Observations { get; set; }
        public Nullable<bool> Approval_Status { get; set; }
        public Nullable<int> Email_Sent_Count { get; set; }
        public string DutyManagerRemarks { get; set; }
    
        public virtual TaxiwayInspectionObservation TaxiwayInspectionObservation { get; set; }
    }
}
