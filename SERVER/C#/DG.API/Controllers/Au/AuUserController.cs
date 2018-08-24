using DG.API.SERVICE.Authorize.AuUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DG.API.Controllers.Au
{
    [RoutePrefix("api/auth/AuUser")]
    [Route("{id?}")]
    public class AuUserController : ApiController
    {
        private readonly IAuUserService _service;
        public AuUserController(IAuUserService service)
        {
            _service = service;
        }

        [Authorize(Roles = "MEMBER")]
        public IHttpActionResult Get()
        {
            return Ok();
        }
    }
}
