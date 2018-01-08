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
    public class RunwayImageDataController : ApiController
    {

        private Airside_Safety_ProjectEntities Entities = new Airside_Safety_ProjectEntities();
        [HttpPost]
        public async Task<IHttpActionResult> GetRunwayChecklistDetails(ImageDataModel model)
          {
              foreach (var item in model.imagepara)
              {
                var data = await Task.Run(() => Entities.SP_InsertRunwayImageDetails(model.date,model.Time,Convert.ToInt32(item.id),item.filename));
                
            }

              return null;
        }
    }
}
