using FilterInjection.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterInjection.Filters
{
    public class DummyBasicAuthChecker : IBasicAuthChecker
    {
        public void Check(HttpContext context, string key, string value)
        {

        }
    }
}
