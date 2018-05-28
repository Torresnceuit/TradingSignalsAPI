using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TradingSignalAPI.Models.Signal;

namespace TradingSignalAPI.Controllers
{
    [RoutePrefix("api/signals")]
    public class SignalsController : BaseApiController
    {
        /// <summary>
        /// Get all signals
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [Route("Get")]
        [HttpGet]
        public IHttpActionResult Get()
        {

            List<SignalViewModel> signals = Db.Signals
                .ToList()
                .Select(m => new SignalViewModel(m))
                .OrderByDescending(h=>h.OpenTime)
                .ToList();
                
                
               
            return Ok(signals);
        }
        /// <summary>
        /// Update signal when it is closed or modified
        /// </summary>
        /// <param name="signal"></param>
        /// <returns></returns>
        [Route("Update")]
        [HttpPost]
        public async Task<IHttpActionResult> Update(Signal signal)
        {
            Signal exist = await Db.Signals.Where(h => h.Id == signal.Id).FirstOrDefaultAsync();
            if (exist == null)
            {
                exist = new Signal();
                exist.Id = signal.Id;
                Db.Signals.Add(exist);
            }
            exist.Update(signal);
            
            await Db.SaveChangesAsync();
            return Ok();
        }

    }
}
