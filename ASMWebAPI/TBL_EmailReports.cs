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
    
    public partial class TBL_EmailReports
    {
        public int EmailReportID { get; set; }
        public string ChecklistObservation { get; set; }
        public Nullable<int> DeptID { get; set; }
        public Nullable<int> Priority { get; set; }
        public Nullable<System.DateTime> EscalatedDate { get; set; }
        public Nullable<int> IsActive { get; set; }
        public Nullable<int> EscalationLevel { get; set; }
    }
}
