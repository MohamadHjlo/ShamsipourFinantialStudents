using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShamsipourOnlineSystem.Data;
using ShamsipourOnlineSystem.Data.Repositories;

namespace ShamsipourOnlineSystem.Components
{
    public class StudentStatusComponent :ViewComponent
    {
        private IStudentRepository _studentReposiroty;
        private ShamsipourOnlineSystem_DBContext _context;

        public StudentStatusComponent(ShamsipourOnlineSystem_DBContext context,IStudentRepository studentReposiroty)
        {
            _context = context;
            _studentReposiroty=studentReposiroty;
        }
        public async Task<IViewComponentResult> InvokeAsync(string userId)
        {
           
            return View("/Views/Components/StudentStatusViewComponent.cshtml", (_studentReposiroty.GetStudentStatusHistory(userId))
            );
        }
    }
}
