using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnMiddleware.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnMiddleware.Pages
{
    public class IndexModel : PageModel
    {
        private IMonitoring _monitoring;

        //Some of interface been auto injected by .net core when start up the web app.
        //like IHttpContextAccessor, you can use directly inside your class, no need to register in Startup.cs
        //IHttpContextAccessor use for access http request and response.
        public IndexModel(IMonitoring monitoring, IHttpContextAccessor accessor) {
            HttpRequest request = accessor.HttpContext.Request;
            HttpResponse response = accessor.HttpContext.Response;

            _monitoring = monitoring;
        }

        public void OnGet()
        {
            _monitoring.Monitor("website.index.load:1|c");
        }
    }
}
