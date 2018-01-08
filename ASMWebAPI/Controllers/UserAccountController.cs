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
    public class UserAccountController : ApiController
    {
        private Airside_Safety_ProjectEntities asp = new Airside_Safety_ProjectEntities();
        [HttpGet]
        public async Task<IHttpActionResult> GetUsers()
        {
            var data = await Task.Run(() => asp.Sp_GetUsers());

            return Ok(data);
        }
        [HttpPost]
        public async Task<IHttpActionResult> AddUser(RegisterLoginUser model)
        {
            var data = await Task.Run(() => asp.SP_REGISTER_USER(model.username, model.password, model.firstname, model.lastname,model.emailid,model.profileoptionRadio));
            return Ok(data);
        }
    }
}
