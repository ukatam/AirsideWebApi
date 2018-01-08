using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASMWebAPI.Models
{
  

    public class ApronInsertModel
    {
        public DateTime date { get; set; }
        public List<ApronInterface> paramset { get; set; }
        public TimeSpan inspectiontime { get; set; }
        public string safetyofficiername { get; set; }
        public string otherobservations { get; set; }

    }
    public class ApronInterface
    {
        public string stand { get; set; }
        public string surfcond { get; set; }
        public string marking { get; set; }
        public string cleaning { get; set; }
        public string serviceability { get; set; }
        public string actiontaken { get; set; }

    }
}