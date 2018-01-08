using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using ASMWebAPI.Models;

namespace ASMWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ApronChecklistController : ApiController
    {
        public Airside_Safety_ProjectEntities Entities = new Airside_Safety_ProjectEntities();

        [HttpGet]
        public async Task<IHttpActionResult> GetApronChecklists()
        {
            var data = await Task.Run(() => Entities.Get_NewApronChecklists());
            return Ok(data);
        }

        //[HttpPost]
        //public async Task<IHttpActionResult> InsertApronChecklistData([FromBody] ApronChecklistProperty postparams)
        //{
        //    var data = await Task.Run(() => Entities.SP_INSERT_APRONCHECKLISTDATA(postparams.date, postparams.inspectiontime, postparams.standone, postparams.surfcondone, postparams.markingone, postparams.cleaningone, postparams.serviceabilityone, postparams.standtwo, postparams.surfcondtwo, postparams.markingtwo, postparams.cleaningtwo, postparams.serviceabilitytwo, postparams.standthree, postparams.surfcondthree, postparams.markingthree, postparams.cleaningthree, postparams.serviceabilitythree, postparams.standfour, postparams.surfcondfour, postparams.markingfour, postparams.cleaningfour, postparams.serviceabilityfour, postparams.standfive, postparams.surfcondfive, postparams.markingfive, postparams.cleaningfive, postparams.serviceabilityfive, postparams.standsix, postparams.surfcondsix, postparams.markingsix, postparams.cleaningsix, postparams.serviceabilitysix, postparams.standseven, postparams.surfcondseven, postparams.markingseven, postparams.cleaningseven, postparams.serviceabilityseven, postparams.standeigth, postparams.surfcondeigth, postparams.markingeigth, postparams.cleaningeigth, postparams.serviceabilityeigth, postparams.standnine, postparams.surfcondnine, postparams.markingnine, postparams.cleaningnine, postparams.serviceabilitynine, postparams.standten, postparams.surfcondten, postparams.markingten, postparams.cleaningten, postparams.serviceabilityten, postparams.standeleven, postparams.surfcondeleven, postparams.markingeleven, postparams.cleaningeleven, postparams.serviceabilityeleven, postparams.standtwelve, postparams.surfcondtwelve, postparams.markingtwelve, postparams.cleaningtwelve, postparams.serviceabilitytwelve, postparams.standthirteen, postparams.surfcondthirteen, postparams.markingthirteen, postparams.cleaningthirteen, postparams.serviceabilitythirteen, postparams.standfourteen, postparams.surfcondfourteen, postparams.markingfourteen, postparams.cleaningfourteen, postparams.serviceabilityfourteen, postparams.standfifteen, postparams.surfcondfifteen, postparams.markingfifteen, postparams.cleaningfifteen, postparams.serviceabilityfifteen, postparams.standsixteen, postparams.surfcondsixteen, postparams.markingsixteen, postparams.cleaningsixteen, postparams.serviceabilitysixteen, postparams.standseventeen, postparams.surfcondseventeen, postparams.markingseventeen, postparams.cleaningseventeen, postparams.serviceabilityseventeen, postparams.standeighteen, postparams.surfcondeighteen, postparams.markingeighteen, postparams.cleaningeighteen, postparams.serviceabilityeighteen, postparams.standnineteen, postparams.surfcondnineteen, postparams.markingnineteen, postparams.cleaningnineteen, postparams.serviceabilitynineteen, postparams.standtwenty, postparams.surfcondtwenty, postparams.markingtwenty, postparams.cleaningtwenty, postparams.serviceabilitytwenty, postparams.standtwentyone, postparams.surfcondtwentyone, postparams.markingtwentyone, postparams.cleaningtwentyone, postparams.serviceabilitytwentyone, postparams.standtwentytwo, postparams.surfcondtwentytwo, postparams.markingtwentytwo, postparams.cleaningtwentytwo, postparams.serviceabilitytwentytwo, postparams.standtwentythree, postparams.surfcondtwentythree, postparams.markingtwentythree, postparams.cleaningtwentythree, postparams.serviceabilitytwentythree, postparams.safetyofficiername, postparams.otherobservations
        //        ,postparams.actiontakenone,postparams.actiontakentwo,postparams.actiontakenthree,postparams.actiontakenfour,postparams.actiontakenfive,postparams.actiontakensix,postparams.actiontakenseven,postparams.actiontakeneigth,postparams.actiontakennine,postparams.actiontakenten,postparams.actiontakeneleven,postparams.actiontakentwelve,postparams.actiontakenthirteen,postparams.actiontakenfourteen,postparams.actiontakenfifteen,postparams.actiontakensixteen,postparams.actiontakenseventeen,postparams.actiontakeneighteen,postparams.actiontakennineteen,postparams.actiontakentwenty,postparams.actiontakentwentyone,postparams.actiontakentwentytwo,postparams.actiontakentwentythree));
        //    return Ok(data);
        //}

        [HttpPost]
        public async Task<IHttpActionResult> InsertApronChecklistData([FromBody] ApronInsertModel model)
        {
         

            foreach (var item in model.paramset)
            {
                var data = await Task.Run(() => Entities.SP_INSERT_APRONCHECKLISTDATA_1(model.date, model.inspectiontime,item.stand,item.surfcond,item.marking,item.cleaning,item.serviceability,item.actiontaken,model.safetyofficiername,model.otherobservations));

            }

            return null;
        }
        }
    }
