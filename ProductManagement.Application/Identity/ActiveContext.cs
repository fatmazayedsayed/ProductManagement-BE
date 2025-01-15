using Microsoft.AspNetCore.Http;
using ProductManagement.Common.Enum;

namespace ProductManagement.Application.Identity
{

    public class ActiveContext
    {
        public Guid UserId { get; set; }
          public string UserName { get; internal set; }
        public UserType UserType { get; internal set; }

        public static ActiveContext GetActiveContext(IServiceProvider serviceProvider)
        {
            var httpContextAccessor = serviceProvider.GetService(typeof(IHttpContextAccessor)) as IHttpContextAccessor;
            var activeContext = httpContextAccessor?.HttpContext?.Items["ActiveContext"] as ActiveContext;
            return activeContext;
        }
    }

}
