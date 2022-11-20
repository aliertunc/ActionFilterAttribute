using ActionFilterAttribute.Exceptions;
using ActionFilterAttribute.Model;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;

namespace ActionFilterAttribute.ActionFilters
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]

    public class RequireTenantNameAttribute : Microsoft.AspNetCore.Mvc.Filters.ActionFilterAttribute
    {
        private readonly string headerKey;

        public RequireTenantNameAttribute(string headerKey = "tenant-name")
        {
            this.headerKey = headerKey;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //This ActionFilter working only, where used this ActionFilter not other controllers
            if (!context.ActionDescriptor.FilterDescriptors.Any(i => i.Filter.GetType() == typeof(RequireTenantNameAttribute)))
                return;

            var header = context.HttpContext.Request.Headers;

            if (header is null || !header.Any() || !header.ContainsKey(headerKey))
                throw new MissingTenantNameException();

            var tenantName = header[headerKey].ToString();
            var tenantModel = context.HttpContext.RequestServices.GetService(typeof(TenantModel)) as TenantModel;
            tenantModel.Name = tenantName;
        }
    }
}
