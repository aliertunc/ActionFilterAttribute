using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;

namespace ActionFilterAttribute.ActionFilters
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AdvangeLoggingAttribute : Microsoft.AspNetCore.Mvc.Filters.ActionFilterAttribute
    {
        private ILogger<AdvangeLoggingAttribute> logger;

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //This ActionFilter working only, where used this ActionFilter not other controllers
            if (!context.ActionDescriptor.FilterDescriptors.Any(i => i.Filter.GetType() == typeof(AdvangeLoggingAttribute)))
            {
                await next();
                return;
            }
            var logger = context.HttpContext.RequestServices.GetService<ILogger<AdvangeLoggingAttribute>>();

            //Before

            logger.LogInformation("Before action execute, with url: " + context.HttpContext.Request.Path);
      
            await next();
             
            logger.LogInformation("Before action execute, with statuscode: " + context.HttpContext.Response.StatusCode);
            //After
        }
    }
}
