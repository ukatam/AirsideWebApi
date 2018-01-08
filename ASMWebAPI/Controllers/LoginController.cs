using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Threading.Tasks;
using System.Web.Http.Description;
using ASMWebAPI.Models;

namespace ASMWebAPI.Controllers
{
    //[EnableCors(origins: "*", methods: "*", headers: "*")]
    public class LoginController : ApiController
    {
        private Airside_Safety_ProjectEntities asp = new Airside_Safety_ProjectEntities();

        [HttpPost]
        public async Task<IHttpActionResult> Login([FromBody] LoginProperty postparams)
        {
            var data = await Task.Run(() => asp.GET_USERLOGIN(postparams.uM_USER_NAME, postparams.uM_PASSWORD));
            return Ok(data);
        }
    }
}
