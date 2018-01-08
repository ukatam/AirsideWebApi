using System.Threading.Tasks;
using System.Web.Http;

namespace ASMWebAPI.Controllers
{
    public class TaxiwayApprovalListController : ApiController
    {
        public Airside_Safety_ProjectEntities Entities = new Airside_Safety_ProjectEntities();
        [HttpGet]
        public async Task<IHttpActionResult> GetTaxiwayApprovalChecklists()
        {
            var data = await Task.Run(() => Entities.GetTaxiwayApprovalTicketList());
            return Ok(data);
        }
    }
}
