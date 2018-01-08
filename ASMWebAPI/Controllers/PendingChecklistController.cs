using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ASMWebAPI.Controllers
{
    public class PendingChecklistController : ApiController
    {
        private Airside_Safety_ProjectEntities entities = new Airside_Safety_ProjectEntities();
        [HttpGet]
        public async Task<IHttpActionResult> GetRunwayChecklists()
        {
            var data = await Task.Run(() => entities.GetPendingTicketList());
            return Ok(data);
        }
    }
}
