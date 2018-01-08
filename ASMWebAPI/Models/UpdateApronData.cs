using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASMWebAPI.Models
{
    public class UpdateApronData
    {
        public List<ApronUpdateInterface> paramset { get; set; }
    }

    public class ApronUpdateInterface
    {
        public int AIC_ID { get; set; }
        public string ActionTaken { get; set; }
        public string Cleaning { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Inspection_Time { get; set; }
        public string Markings { get; set; }
        public string OfficerName { get; set; }
        public string Other_Observations { get; set; }
        public string Serviceability { get; set; }
        public string Stand { get; set; }
        public string Surface_Condition { get; set; }
       
      
      
       
    }
}