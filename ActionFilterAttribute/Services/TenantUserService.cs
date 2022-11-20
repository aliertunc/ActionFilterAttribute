using ActionFilterAttribute.Model;
using System.Collections.Generic;

namespace ActionFilterAttribute.Services
{
    public class TenantUserService
    {
        private readonly TenantModel tenantModel;

        public TenantUserService(TenantModel tenantModel)
        {
            this.tenantModel = tenantModel;
        }
        public IEnumerable<User> GetAllUsers()
        {  
            return new List<User>()
        {
            new User() { Id = 2, EmailAddress = $"ertuncali07@gmail.com_{tenantModel.Name}"}
        };
        }
    }
}
