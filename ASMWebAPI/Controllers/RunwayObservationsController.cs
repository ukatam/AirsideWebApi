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
    public class RunwayObservationsController : ApiController
    {
        private Airside_Safety_ProjectEntities entities = new Airside_Safety_ProjectEntities();
        [HttpGet]
        public async Task<IHttpActionResult> GetObservation()
        {
            var data = await Task.Run(() => entities.Get_RunwayInspection_Observation());
            return Ok(data);
        }
        [HttpPost]
        public async Task<IHttpActionResult> GetObservation(Get_RunwayInspection_Checklist_Report_Result model)
        {
            var data = await Task.Run(() => entities.Insert_RunwayInspection_Checklist_Mobile(model.Date,model.RWY_Inspected,model.Inspection_Time,model.Acceptability,model.Action_Taken,model.NC_Filed_Ref_No,model.Department_Name,model.Person_Name,model.Other_Observations));
            return Ok(data);
        }
    }
}
