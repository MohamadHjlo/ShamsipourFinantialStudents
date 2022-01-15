using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using ShamsipourOnlineSystem.Data;
using ShamsipourOnlineSystem.Data.Repositories;
using ShamsipourOnlineSystem.Models;
using ShamsipourOnlineSystem.ViewModels;

namespace ShamsipourOnlineSystem.Controllers
{
    [Authorize]
    
    public class GraduatesExpertController : Controller
    {
        private ShamsipourOnlineSystem_DBContext _context;

        public GraduatesExpertController(ShamsipourOnlineSystem_DBContext context)
        {
            _context = context;
        }
        [RoleManager("GraduatesExpert")]
        public IActionResult Index()
        {
            var students = new GraduatesExpertViewModel()
            {
                GraduatesExpertStudents = _context.GraduatesExpertStudents.Where(s => s.StageStatus == null).ToList()
            };
            return View("/Views/GraduatesExpert/GraduatesExpert.cshtml", students);
        }
        [RoleManager("GraduatesExpert")]
        [HttpPost]
        public IActionResult SetAsReversed(string studentId, string reversedescribtion)
        {
            var student = _context.Students.Include(s => s.GraduatesExpert).FirstOrDefault(s => s.StudentId == studentId);
            if (student != null)
            {
                student.IsReversed = true;
                student.IsPending = false;
                student.IsFinaled = false;
                student.GraduatesExpert.StageStatus = false;
                student.GraduatesExpert.CheckoutTime = DateTime.Now;
                student.GraduatesExpert.StudentDescribtion = "";
                student.GraduatesExpert.ReverseDescribtion = reversedescribtion;
                _context.SaveChanges();
                return Json(true);
            }
            else
            {
                return Json("nullstates");
            }
        }
        [RoleManager("GraduatesExpert")]
        [HttpPost]
        public IActionResult SetAsReversedToEduExpert(string studentId, string edureversedescribtion)
        {
            var student = _context.Students.Include(s => s.EduExpert).Include(s => s.GraduatesExpert).FirstOrDefault(s => s.StudentId == studentId);
            if (student != null)
            {
                student.IsReversed = true;
                student.IsPending = false;
                student.IsFinaled = false;
                student.GraduatesExpert.CheckoutTime=DateTime.Now;
                student.GraduatesExpert.StageStatus = false;
                student.EduExpert.IsReversedFromGradExpert = true;
                student.EduExpert.StageStatus = null;
                student.EduExpert.GradReverseDescribtion = edureversedescribtion;
                _context.SaveChanges();
                return Json(true);
            }
            else
            {
                return Json("nullstates");
            }
        }
        [RoleManager("GraduatesExpert")]
        [HttpPost]
        public IActionResult SetAsSuccessed(string studentId, string studentdescribtion)
        {
            var financialstudent = new FinancialStudent()
            {
                StudentId = studentId,
                StudentDescribtion = studentdescribtion
            };


            var student = _context.Students
                .Include(s => s.Financial)
                .Include(s => s.GraduatesExpert)
                .FirstOrDefault(s => s.StudentId == studentId);


            _context.FinancialStudents.Add(financialstudent);
            _context.SaveChanges();
            student.FinancialId = financialstudent.Id;
            _context.SaveChanges();


            student.GraduatesExpert.CheckoutTime = DateTime.Now;
            student.GraduatesExpert.StageStatus = true;
            student.Financial.StudentDescribtion = studentdescribtion;
            student.Financial.StageStatus = null;
            student.IsFinaled = false;
            student.IsPending = true;
            student.IsReversed = false;
            _context.SaveChanges();
            return Json(true);
        }

        [HttpPost]
        public IActionResult RecheckStudent(string studentId, string studentdescribtion)
        {
            var student = _context.Students.Include(s => s.GraduatesExpert).FirstOrDefault(s => s.StudentId == studentId);
            if (student == null) return Json(false);
            student.IsReversed = false;
            student.IsPending = true;
            student.IsFinaled = false;
            student.GraduatesExpert.StageStatus = null;
            student.GraduatesExpert.StudentDescribtion = studentdescribtion;
            _context.SaveChanges();
            return Json(true);

        }
        [RoleManager("GraduatesExpert")]
        public IActionResult GetHistoryOfStudents()
        {
            var students = new GraduatesExpertViewModel()
            {
                GraduatesExpertStudents = _context.GraduatesExpertStudents.Where(s => s.StageStatus != null).ToList()
            };

            return View("GradStudentsHistory", students);
        }
    }
}
