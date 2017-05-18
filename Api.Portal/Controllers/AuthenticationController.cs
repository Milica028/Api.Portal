using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Portal.IBusinessLogic;

namespace Api.Portal.Controllers
{
    public class PortalController : ApiController
    {
        private readonly IUserBL _userBl;
        public PortalController(IUserBL userBl)
        {
            _userBl = userBl;
        }
        public IHttpActionResult Get()
        {
            return Ok(_userBl.GetList());
        }
    }
}
