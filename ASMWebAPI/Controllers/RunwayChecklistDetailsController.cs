using ASMWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ASMWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class RunwayChecklistDetailsController : ApiController
    {
        private Airside_Safety_ProjectEntities entities = new Airside_Safety_ProjectEntities();
        [HttpPost]
        public async Task<IHttpActionResult> GetRunwayChecklistDetails(RunwayChecklistParams model)
        {
            var data = await Task.Run(() => entities.Get_RunwayInspection_Checklist_Report(model.date, model.time));
            return Ok(data);
        }
    }
}
