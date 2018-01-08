using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ASMWebAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        private Airside_Safety_ProjectEntities asp = new Airside_Safety_ProjectEntities();
        [HttpGet]
        public async Task<IHttpActionResult> GetDepartments()
        {
            var data = await Task.Run(() => asp.SP_GetDepartments());
            return Ok(data);
        }
    }
}
