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
    public class AreaMasterController : ApiController
    {
        public Airside_Safety_ProjectEntities Entities = new Airside_Safety_ProjectEntities();
        [HttpGet]
        public async Task<IHttpActionResult> TaxiwayAreaMaster(int id)
        {
            var data = await Task.Run(() => Entities.Sp_TaxiwayAreaMaster(id));
            return Ok(data);
        }
      
    }
}
