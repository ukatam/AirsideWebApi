using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ASMWebAPI.Models;

namespace ASMWebAPI.Controllers
{
    public class EscalationStatusController : ApiController
    {
        public Airside_Safety_ProjectEntities Entities = new Airside_Safety_ProjectEntities();
        [HttpPost]
        public async Task<IHttpActionResult> ChangeEscalationStatus(ChangeEscalation model)
        {
            var data = await Task.Run(() => Entities.SP_ChangeEscalationStatus(model.ReportId, model.Status));
            return Ok(data);
        }
    }
}
