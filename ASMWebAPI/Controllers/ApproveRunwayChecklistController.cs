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
    public class ApproveRunwayChecklistController : ApiController
    {
        public Airside_Safety_ProjectEntities Entities = new Airside_Safety_ProjectEntities();

        [HttpPost]
        public async Task<IHttpActionResult> Approve(ApprovalParam model)
        {
            var data = await Task.Run(() => Entities.ApproveRunwayInspectionChecklist(model.date, model.time, model.approved));
            return Ok(data);
        }
    }
}
