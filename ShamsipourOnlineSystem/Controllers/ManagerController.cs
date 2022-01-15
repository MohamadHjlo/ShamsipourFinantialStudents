using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using ShamsipourOnlineSystem.Data;
using ShamsipourOnlineSystem.Data.Repositories;
using ShamsipourOnlineSystem.ViewModels;

namespace ShamsipourOnlineSystem.Controllers
{
    [RoleManager("Manager")]
    public class ManagerController : Controller
    {
        private ShamsipourOnlineSystem_DBContext _context;

        public ManagerController(ShamsipourOnlineSystem_DBContext context)
        {
            _context = context;
        }
        public IActionResult Index(int Page = 1, int PageSize = 10)
        {
            var students = new ManagerViewModel()
            {
                Students = _context.Students.Where(s=>s.StudentId!=User.FindFirstValue(ClaimTypes.NameIdentifier))
                    .OrderBy(u => u.Id).ToList().Skip((Page - 1) * PageSize).Take(PageSize).ToList(),
                PageSize = PageSize,
                CurrentPage = Page,
                TotalRecords = _context.Students.Count()
            };
            return View("Index", students);
        }

        public IActionResult RemoveStudent(string studentId)
        {
            var student = _context.Students.Where(s => s.StudentId == studentId)
                .Include(s => s.EduExpert)
                .Include(s => s.GraduatesExpert)
                .Include(s => s.Financial)
                .Include(s => s.Dorm)
                .Include(s => s.StudentAffairs)
                .Include(s => s.Library)
                .Include(s => s.Laboratory)
                .Include(s => s.ThesisExpert)
                .Include(s => s.Itexpert)
                .Include(s => s.ResearchAssistant)
                .Include(s => s.FinalGraduatesExpert)
                .FirstOrDefault();

            if (student != null)
            {
                _context.Students.Remove(student);

                if (student.EduExpert != null)
                {
                    _context.EduExpertStudents.RemoveRange(_context.EduExpertStudents.Where(s=>s.StudentId==studentId));
                }
                if (student.GraduatesExpert != null)
                {
                    _context.GraduatesExpertStudents.RemoveRange(_context.GraduatesExpertStudents.Where(s => s.StudentId == studentId));
                }
                if (student.Financial != null)
                {
                    _context.FinancialStudents.RemoveRange(_context.FinancialStudents.Where(s => s.StudentId == studentId));
                }
                if (student.Dorm != null)
                {
                    _context.DormStudents.RemoveRange(_context.DormStudents.Where(s => s.StudentId == studentId));
                }
                if (student.StudentAffairs != null)
                {
                    _context.StudentAffairsStudents.RemoveRange(_context.StudentAffairsStudents.Where(s => s.StudentId == studentId));
                }
                if (student.Library != null)
                {
                    _context.LibraryStudents.RemoveRange(_context.LibraryStudents.Where(s => s.StudentId == studentId));
                }
                if (student.Laboratory != null)
                {
                    _context.LaboratoryStudents.RemoveRange(_context.LaboratoryStudents.Where(s => s.StudentId == studentId));
                }
                if (student.ThesisExpert != null)
                {
                    _context.ThesisExpertStudents.RemoveRange(_context.ThesisExpertStudents.Where(s => s.StudentId == studentId));
                }
                if (student.Itexpert != null)
                {
                    _context.ItexpertStudents.RemoveRange(_context.ItexpertStudents.Where(s => s.StudentId == studentId));
                }
                if (student.ResearchAssistant != null)
                {
                    _context.ResearchAssistantStudents.RemoveRange(_context.ResearchAssistantStudents.Where(s => s.StudentId == studentId));
                }
                if (student.FinalGraduatesExpert != null)
                {
                    _context.FinalGraduatesExpertStudents.RemoveRange(_context.FinalGraduatesExpertStudents.Where(s => s.StudentId == studentId));
                }
            }
            _context.SaveChanges();


            return Json(true);
        }

        public IActionResult EditStudent(int Id,string studentId)
        {
            var student=_context.Students.FirstOrDefault(s=>s.Id==Id).StudentId==studentId;
            _context.SaveChanges();

            return Json(true);
        }
    }
}
