using System.Threading.Tasks;
using System.Web.Http;
using ASMWebAPI.Models;

namespace ASMWebAPI.Controllers
{
    public class TaxiwayChecklistDetailsController : ApiController
    {
        private Airside_Safety_ProjectEntities entities = new Airside_Safety_ProjectEntities();
        [HttpPost]
        public async Task<IHttpActionResult> GetTaxiwayChecklistDetails(RunwayChecklistParams model)
        {
            var data = await Task.Run(() => entities.Get_TaxiwayInspection_Checklist_Report(model.date, model.time));
            return Ok(data);
        }
    }
}
