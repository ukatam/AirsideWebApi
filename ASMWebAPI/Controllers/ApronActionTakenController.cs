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
    public class ApronActionTakenController : ApiController
    {
        private Airside_Safety_ProjectEntities asp = new Airside_Safety_ProjectEntities();

        //[HttpPost]
        //public async Task<IHttpActionResult> EditChecklistModel([FromBody] ActionTakenModel postparams)
        //{
        //    var data = await Task.Run(() => asp.SP_UpdateActionTaken(
        //        postparams.date,
        //        postparams.time,
        //        postparams.acceptability0,
        //        postparams.acceptability1,
        //        postparams.acceptability2,
        //        postparams.acceptability3,
        //        postparams.acceptability4,
        //        postparams.acceptability5,
        //        postparams.acceptability6,
        //        postparams.acceptability7,
        //        postparams.acceptability8,
        //        postparams.acceptability9,
        //        postparams.acceptability10,
        //        postparams.acceptability11,
        //        postparams.acceptability12,
        //        postparams.acceptability13,
        //        postparams.acceptability14,
        //        postparams.acceptability15,
        //        postparams.acceptability16,
        //        postparams.acceptability17,
        //        postparams.acceptability18,
        //        postparams.acceptability19,
        //        postparams.ncfiled0,
        //        postparams.ncfiled1,
        //        postparams.ncfiled2,
        //        postparams.ncfiled3,
        //        postparams.ncfiled4,
        //        postparams.ncfiled5,
        //        postparams.ncfiled6,
        //        postparams.ncfiled7,
        //        postparams.ncfiled8,
        //        postparams.ncfiled9,
        //        postparams.ncfiled10,
        //        postparams.ncfiled11,
        //        postparams.ncfiled12,
        //        postparams.ncfiled13,
        //        postparams.ncfiled14,
        //        postparams.ncfiled15,
        //        postparams.ncfiled16,
        //        postparams.ncfiled17,
        //        postparams.ncfiled18,
        //        postparams.ncfiled19,
        //        postparams.actiontaken0,
        //        postparams.actiontaken1,
        //        postparams.actiontaken2,
        //        postparams.actiontaken3,
        //        postparams.actiontaken4,
        //        postparams.actiontaken5,
        //        postparams.actiontaken6,
        //        postparams.actiontaken7,
        //        postparams.actiontaken8,
        //        postparams.actiontaken9,
        //        postparams.actiontaken10,
        //        postparams.actiontaken11,
        //        postparams.actiontaken12,
        //        postparams.actiontaken13,
        //        postparams.actiontaken14,
        //        postparams.actiontaken15,
        //        postparams.actiontaken16,
        //        postparams.actiontaken17,
        //        postparams.actiontaken18,
        //        postparams.actiontaken19));
        //    return Ok(data);
        //}paramset
        [HttpPost]
        public async Task<IHttpActionResult> UpdateApronChecklistData([FromBody] UpdateApronData model)
        {
            var data1 = "";
            foreach (var item in model.paramset)
            {
               var  data = await Task.Run(() => asp.SP_UPDATE_APRONCHECKLISTDATA(item.AIC_ID,item.Date, item.Inspection_Time, item.Stand, item.Surface_Condition, item.Markings, item.Cleaning, item.Serviceability, item.ActionTaken));

            }

            return Ok(data1);

        }
    }
}
