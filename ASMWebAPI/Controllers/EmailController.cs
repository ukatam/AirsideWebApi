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
    public class EmailController : ApiController
    {
        private Airside_Safety_ProjectEntities asp = new Airside_Safety_ProjectEntities();
        [HttpGet]
        public async Task<IHttpActionResult> getReportDetails(int id)
        {
            var data = await Task.Run(() => asp.SP_EmailReportDetails(id));
            return Ok(data);
        }
        [HttpPost]
        public async Task<IHttpActionResult> sendMail(EmailModel model)
        {
            var data = await Task.Run(() => asp.SP_InsertEmailReport(model.Dept_ID, model.Priority, model.observation));
            return Ok(data);
        }
    }
}
