using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASMWebAPI.Models
{
    public class ApronChecklistApproval
    {
        public string Remarks { get; set; }
        public bool ApprovalStatus { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
    }
}