using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FilterInjection.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilterInjection.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]

    //ServiceFilter will resolve your type from DI
    //Underlining all the injected constructor will auto invoke
    [TypeFilter(typeof(BasicAuthFilterAttribute), Arguments = new object[] {1, 35})]
    public class MyApiController : ControllerBase
    {
        [Route("Do")]
        public HttpResponseMessage Do() {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}