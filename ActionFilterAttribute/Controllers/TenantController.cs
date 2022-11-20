using ActionFilterAttribute.ActionFilters;
using ActionFilterAttribute.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActionFilterAttribute.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [RequireTenantName(headerKey: "tenant-name")]

    public class TenantController : ControllerBase
    {
        private readonly TenantUserService tenantUserService;
        public TenantController(TenantUserService tenantUserService)
        {
            this.tenantUserService = tenantUserService;
        }
        [HttpGet]
        public ActionResult GetUsers()
        {
            var users = tenantUserService.GetAllUsers();

            return Ok(users);
        }

    }
}
