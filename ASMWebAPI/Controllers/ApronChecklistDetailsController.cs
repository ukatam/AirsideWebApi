using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Threading.Tasks;
using ASMWebAPI.Models;

namespace ASMWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ApronChecklistDetailsController : ApiController
    {
        private Airside_Safety_ProjectEntities entities = new Airside_Safety_ProjectEntities();
        [HttpPost]
        public async Task<IHttpActionResult> GetRunwayChecklistDetails(ApronChecklistDetails model)
        {
            var data = await Task.Run(() => entities.Get_ApronInspection_Checklist_Report(model.date, model.time));
            return Ok(data);
        }
    }
}
