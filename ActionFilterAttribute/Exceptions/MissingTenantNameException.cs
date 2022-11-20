using System;


namespace ActionFilterAttribute.Exceptions
{
    public class MissingTenantNameException : Exception
    {
        public MissingTenantNameException()
        : base(message: "TenantName must be provided by header")
        {

        }
    }

}
