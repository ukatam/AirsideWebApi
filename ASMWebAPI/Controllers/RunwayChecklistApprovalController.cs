using ASMWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ASMWebAPI.Controllers
{
    public class RunwayChecklistApprovalController : ApiController
    {
        private Airside_Safety_ProjectEntities entities = new Airside_Safety_ProjectEntities();

     

        [HttpPost]
        public async Task<IHttpActionResult> ChecklistApproval(ChecklistApproval model)
        {
         
            var data = await Task.Run(() => entities.UpdateApprovalDetails(model.Date, model.Time, model.Remarks, model.ApprovalStatus));
            return Ok(data);
        }
    }
}
