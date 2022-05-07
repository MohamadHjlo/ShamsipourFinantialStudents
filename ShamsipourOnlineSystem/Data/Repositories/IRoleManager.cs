using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using ShamsipourOnlineSystem.Models;

namespace ShamsipourOnlineSystem.Data.Repositories
{

    public interface IRoleManager
    {
        public void OnAuthorization(AuthorizationFilterContext context);
    }
    public class RoleManager : AuthorizeAttribute, IAuthorizationFilter,IRoleManager
    {
        readonly string _roleName;

        Responsible _user;
        public RoleManager(string roleName)
        {
            _roleName = roleName;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            using ShamsipourOnlineSystem_DBContext _context = new ShamsipourOnlineSystem_DBContext();
            var roles = _context.UserRoles.Include(u => u.Role).Include(u => u.User).AsNoTracking();
            if (roles.Select(r => r.Role) != null)
            {
                if (context.HttpContext.User.Identity.IsAuthenticated)
                {
                    string userId = context.HttpContext.User.FindFirstValue("ID");
                    _user = (Responsible)context.HttpContext.RequestServices.GetService(typeof(Responsible));


                    if (!roles.Any(r => r.UserId.ToString() == userId && r.Role.RoleName == _roleName))
                    {
                        context.Result = new RedirectResult("/Account/Register");
                    }
                }

                else
                {
                    context.Result = new RedirectResult("/Account/Register");
                }
            }
        }
    }
}
