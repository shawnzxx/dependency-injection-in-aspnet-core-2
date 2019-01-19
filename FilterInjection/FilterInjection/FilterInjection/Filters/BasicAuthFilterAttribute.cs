using FilterInjection.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterInjection.Filters
{
    public class BasicAuthFilterAttribute : Attribute, IActionFilter
    {
        private readonly IBasicAuthChecker _authChecker;
        public BasicAuthFilterAttribute(IBasicAuthChecker authChecker, int sessionId, int cacheId)
        {
            _authChecker = authChecker;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            const string HeaderKey = "Authorization";
            const string HeaderValue = "Basic MyAuthKey";
            
            _authChecker.Check(context.HttpContext, HeaderKey, HeaderValue);

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

        }
    }
}
