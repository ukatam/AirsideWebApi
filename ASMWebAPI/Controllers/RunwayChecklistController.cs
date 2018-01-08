using ASMWebAPI.Models;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ASMWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class RunwayChecklistController : ApiController
    {
        public Airside_Safety_ProjectEntities Entities = new Airside_Safety_ProjectEntities();
        [HttpGet]
        public async Task<IHttpActionResult> GetRunwayChecklists()
        {
            var data = await Task.Run(() => Entities.Get_NewChecklists());
            return Ok(data);
        }
     
        [HttpPost]
        public async Task<IHttpActionResult> InsertChecklistData([FromBody] RunwayChecklistProperty postparams)
        {
            var data = await Task.Run(() => Entities.SP_INSERT_RUNWAYCHECKLISTDATA(postparams.date, postparams.rwyinspected, postparams.inspectiontime, postparams.approachlightsign,postparams.approachlightAction, postparams.approachlightNC, postparams.runwayedgelightsign,postparams.runwayedgelightAction, postparams.runwayedgelightNC, postparams.papisign,postparams.papiAction, postparams.papiNC, postparams.runwaycentrelightsign,postparams.runwaycentrelightAction, postparams.runwaycentrelightNC, postparams.runwaythrlightsign,postparams.runwaythrlightAction, postparams.runwaythrlightNC, postparams.runwayendlightsign,postparams.runwayendlightAction, postparams.runwayendlightNC, postparams.runwaytdzlightsign,postparams.runwaytdzlightAction, postparams.runwaytdzlightNC, postparams.retilsandtwylightsign,postparams.retilsandtwylightAction, postparams.retilsandtwylightNC, postparams.runwaysurfacesign,postparams.runwaysurfaceAction, postparams.runwaysurfaceNC, postparams.fodsign,postparams.fodAction, postparams.fodNC, postparams.runwayshouldersign,postparams.runwayshoulderAction, postparams.runwayshoulderNC, postparams.runwaymarkingsign,postparams.runwaymarkingAction, postparams.runwaymarkingNC, postparams.rubberbuildupsign,postparams.rubberbuildupAction, postparams.rubberbuildupNC, postparams.opencablingsign,postparams.opencablingAction, postparams.opencablingNC, postparams.lightingvisibilitysign,postparams.lightingvisibilityAction, postparams.lightingvisibilityNC, postparams.birdsign,postparams.birdAction, postparams.birdNC, postparams.dampwetsign,postparams.dampwetAction, postparams.dampwetNC, postparams.spillagesign,postparams.spillageAction, postparams.spillageNC, postparams.obstructionsign,postparams.obstructionAction, postparams.obstructionNC, postparams.grasslengthsign,postparams.grasslengthAction, postparams.grasslengthNC, postparams.InspectorName, postparams.InspectorSign, postparams.otherobservations));
            return Ok(data);
        }
    }
}
