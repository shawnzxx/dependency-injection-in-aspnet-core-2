using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterInjection.Interfaces
{
    public interface IBasicAuthChecker
    {
        void Check(HttpContext context, string key, string value);
    }
}
