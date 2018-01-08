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
    public class TaxiwayChecklistController : ApiController
    {
        private Airside_Safety_ProjectEntities asp = new Airside_Safety_ProjectEntities();
        public async Task<IHttpActionResult> GetTaxiwayChecklists()
        {
            var data = await Task.Run(() => asp.Get_NewTaxiwayChecklists());
            return Ok(data);
        }
      
        [HttpPost]
        public async Task<IHttpActionResult> Login([FromBody] TaxiwayChecklistModel postparams)
        {
            var data = await Task.Run(() => asp.SP_INSERT_TAXIWAYCHECKLISTDATA(postparams.FOD,postparams.FODNC,postparams.InspectorName,postparams.InspectorSign,postparams.Obstruction,postparams.ObstructionNC,
                postparams.airsideworks,postparams.airsideworksNC,postparams.birdsign,postparams.birdsignNC,postparams.date,postparams.drainscleanliness,postparams.drainscleanlinessNC,postparams.drainsstructural,postparams.drainsstructuralNC,
                postparams.firehazards,postparams.firehazardsNC,postparams.grasslength,postparams.grasslengthNC,postparams.inspectiontime,postparams.manholesdraincovers,postparams.manholesdraincoversNC,postparams.obviouspavementdamage,postparams.obviouspavementdamageNC,
                postparams.opencabling,postparams.opencablingNC,postparams.otherobservations,postparams.runwayguardlights,postparams.runwayguardlightsNC,postparams.rwyinspected,postparams.signslightning,postparams.signslightningNC,postparams.spillageNC,postparams.spillagesign,postparams.standingwater,
                postparams.standingwaterNC,postparams.taxiwaycentrelinelights,postparams.taxiwaycentrelinelightsNC,postparams.taxiwayedgelights,postparams.taxiwayedgelightsNC,postparams.taxiwaymarkings,postparams.taxiwaymarkingsNC,postparams.taxiwaysurfaces,postparams.taxiwaysurfacesNC,postparams.winddirectionalindicator,postparams.winddirectionalindicatorNC,
                postparams.taxiwayedgelightsAction, postparams.taxiwaycentrelinelightsAction, postparams.runwayguardaction, postparams.taxiwaysurfacesAction, postparams.taxiwayedgelightsAction, postparams.taxiwaymarkingsAction, postparams.obviouspavementdamageAction, postparams.ObstructionAction, postparams.manholesdraincoversAction, 
                postparams.opencablingAction, postparams.signslightningAction, postparams.drainscleanlinessAction, postparams.drainsstructuralAction, postparams.winddirectionalindicatorAction, postparams.birdsignAction, postparams.standingwaterAction, postparams.airsideworksAction, postparams.spillageAction, postparams.firehazardsAction, 
                postparams.grasslengthAction));
            return Ok(data);
        }

    }
}
