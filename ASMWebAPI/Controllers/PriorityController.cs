using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ASMWebAPI.Controllers
{
    public class PriorityController : ApiController
    {
        private Airside_Safety_ProjectEntities asp = new Airside_Safety_ProjectEntities();
        [HttpGet]
        public async Task<IHttpActionResult> getPriority()
        {
            var data = await Task.Run(() => asp.SP_GetPriorityList());
            return Ok(data);
        }
    }
}
