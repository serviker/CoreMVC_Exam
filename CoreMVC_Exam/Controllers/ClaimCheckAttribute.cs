using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoreMVC_Exam.Controllers
{
    [NonController]
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class ClaimCheckAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;

            if (!user.Identity.IsAuthenticated)
                return;

            var isAuthorized = user.Identity is ClaimsIdentity      // у пользователя есть Claims
                               && ((ClaimsIdentity)user.Identity).HasClaim(t => t.Type == ClaimType && t.Value == ClaimValue);

            if (!isAuthorized)
            {
                context.Result = new ForbidResult();
                return;
            }
        }
    }
}
