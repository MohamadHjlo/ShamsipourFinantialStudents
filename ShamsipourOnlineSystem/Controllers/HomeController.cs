using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShamsipourOnlineSystem.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using ShamsipourOnlineSystem.Data;
using ShamsipourOnlineSystem.ViewModels;

namespace ShamsipourOnlineSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ShamsipourOnlineSystem_DBContext _context;
        private readonly ScopeContext _scopeContext;

        public HomeController(ILogger<HomeController> logger, ShamsipourOnlineSystem_DBContext context, ScopeContext scopeContext)
        {
            _logger = logger;
            _context = context;
            _scopeContext = scopeContext;
        }

        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var student = _context.Students.SingleOrDefault(s => s.StudentId == userId);
            var responsible = _context.Responsibles.SingleOrDefault(s => s.ResponsibleId == userId);
            var model = new IndexViewModel()
            {
                Student = student,
                Responsible = responsible
            };

            if (model.Responsible == null && model.Student != null)
            {
                return View(model);
            }

            if (model.Student != null || model.Responsible == null) return View(model);
            if (_scopeContext.IsInRole("Manager", User)) return Redirect("Manager");
            if (_scopeContext.IsInRole("EduExpert", User)) return Redirect("EduExpert");
            if (_scopeContext.IsInRole("GraduatesExpert", User)) return Redirect("GraduatesExpert");
            if (_scopeContext.IsInRole("FinancialExpert", User)) return Redirect("Financial");
            if (_scopeContext.IsInRole("DormExpert", User)) return Redirect("Dorm");
            if (_scopeContext.IsInRole("AffairsExpert", User)) return Redirect("StudentAffairs");
            if (_scopeContext.IsInRole("LibraryExpert", User)) return Redirect("Library");
            if (_scopeContext.IsInRole("LaboratoryExpert", User)) return Redirect("Laboratory");
            if (_scopeContext.IsInRole("ThesisExpert", User)) return Redirect("ThesisExpert");
            if (_scopeContext.IsInRole("ItExpert", User)) return Redirect("ITExpert");
            if (_scopeContext.IsInRole("ResearchExpert", User)) return Redirect("ResearchAssistant");
            return View(model);
        }

        [HttpPost]
        public IActionResult SendToEduExpert(string describtion,bool isAgreed)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var student = _context.Students
                .FirstOrDefault(s => s.StudentId == userId);
            if (_context.Students.Any(e => e.StudentId == userId && e.IsPending == true))
            {
                return Json("DuplicateRequest");
            }

            if (_context.EduExpertStudents.Any(e=>e.StudentId==userId)&&isAgreed==false)
            {
                return Json("RecheckAllWarning");
            }
            var edustudent = new EduExpertStudent()
            {
                StudentDescribtion = describtion,
                StudentId = student.StudentId
            };

            _context.EduExpertStudents.Add(edustudent);
            _context.SaveChanges();
            student.EduExpertId = edustudent.Id;
            student.RequestTime = DateTime.Now;
            student.IsPending = true;
            student.IsFinaled = false;
            student.IsReversed = false;
            _context.SaveChanges();

            return Json(true);

        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
