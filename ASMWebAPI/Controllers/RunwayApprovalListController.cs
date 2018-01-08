using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ASMWebAPI.Controllers
{
    public class RunwayApprovalListController : ApiController
    {
        public Airside_Safety_ProjectEntities Entities = new Airside_Safety_ProjectEntities();
        [HttpGet]
        public async Task<IHttpActionResult> GetRunwayApprovalChecklists()
        {
            var data = await Task.Run(() => Entities.GetRunwayApprovalTicketList());
            return Ok(data);
        }
    }
}
