# ActionFilterAttribute
This is an action filter attribute in ASP.NET Core that logs information before and after an action is executed. It logs the URL of the request and the status code of the response. The attribute is only applied to the controllers where it is used, and not to all controllers in the application. The attribute uses the ILogger service to log the information.


An action filter attribute for requiring a tenant name in the header of an HTTP request. It checks if the request header contains the specified key for the tenant name, and if it is not present, it throws a "MissingTenantNameException". If the header does contain the tenant name, it is saved to a "TenantModel" object which is available in the request services. This action filter is only applied to controllers that have the attribute applied to them, and not to all controllers in the application.
