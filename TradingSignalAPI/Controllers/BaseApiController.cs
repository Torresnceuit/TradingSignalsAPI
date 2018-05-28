using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TradingSignalAPI.Models.Shared;

namespace TradingSignalAPI.Controllers
{
    public class BaseApiController : ApiController
    {

        ApplicationDbContext _db;

        public ApplicationDbContext Db
        {
            get
            {
                return _db ?? Request.GetOwinContext().Get<ApplicationDbContext>();

            }
            set
            {
                _db = value;
            }
        }
    }
}
