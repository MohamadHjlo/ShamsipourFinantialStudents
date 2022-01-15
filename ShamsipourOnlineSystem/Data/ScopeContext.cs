using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using ShamsipourOnlineSystem.Models;

namespace ShamsipourOnlineSystem.Data
{
    public class ScopeContext
    {
        private ShamsipourOnlineSystem_DBContext _context;

        public ScopeContext(ShamsipourOnlineSystem_DBContext context)
        {
            _context = context;
        }


        public bool IsInRole(string rolename,ClaimsPrincipal principal)
        {
            if (!principal.Identity.IsAuthenticated)
            {
                return false;
            }
            var currentUserId=principal.FindFirstValue("ID");

            var roles= _context.UserRoles.Where(r => r.UserId == int.Parse(currentUserId))
                .Include(r => r.Role).ToList();

            return  roles.Any(r=>r.Role.RoleName==rolename);

        }

    }
}
