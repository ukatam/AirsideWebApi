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
    
    public partial class ApronInspectionChecklist
    {
        public int AIC_ID { get; set; }
        public Nullable<System.DateTime> InspectionDate { get; set; }
        public Nullable<System.TimeSpan> Inspection_Time { get; set; }
        public string Stand { get; set; }
        public string Surface_Condition { get; set; }
        public string Markings { get; set; }
        public string Cleaning { get; set; }
        public string Serviceability { get; set; }
        public string ActionTaken { get; set; }
        public string OfficierName { get; set; }
        public string Other_Observations { get; set; }
        public Nullable<bool> ApprovalStatus { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovalDateTime { get; set; }
        public string DutyManagerRemarks { get; set; }
    }
}
