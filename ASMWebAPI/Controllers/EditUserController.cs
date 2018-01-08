using ASMWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ASMWebAPI.Controllers
{
    public class EditUserController : ApiController
    {
        public Airside_Safety_ProjectEntities Entities = new Airside_Safety_ProjectEntities();

        [HttpGet]
        public async Task<IHttpActionResult> GetEditUser(int id)
        {
            var data = await Task.Run(() => Entities.SP_EditUser(id));
            return Ok(data);
        }
        [HttpPost]
        public async Task<IHttpActionResult> DeleteUser(DeleteModel model)
        {
            var data = await Task.Run(() => Entities.SP_DeleteUser(model.id));
            return Ok(data);
        }
    }
}
