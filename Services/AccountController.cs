using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LoginAPI.Models;
using LoginAPI.Services;

namespace LoginAPI.Services
{
    public class AccountController : ApiController
    {

        [HttpPost]
        
        public HttpResponseMessage UserRegistration(RegistrationModel model)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}
