using System.Threading.Tasks;
using System.Web.Http;

namespace ASMWebAPI.Controllers
{
    public class PendingTaxiwayChecklistController : ApiController
    {
        private Airside_Safety_ProjectEntities entities = new Airside_Safety_ProjectEntities();
        [HttpGet]
        public async Task<IHttpActionResult> GetTaxiwayPendingChecklists()
        {
            var data = await Task.Run(() => entities.GetPendingTaxiwayTicketList());
            return Ok(data);
        }
    }
}
