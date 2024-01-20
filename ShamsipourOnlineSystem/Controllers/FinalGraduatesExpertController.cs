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
    
    public class FinalGraduatesExpertController : Controller
    {
        private readonly ShamsipourOnlineSystem_DBContext _context;

        public FinalGraduatesExpertController(ShamsipourOnlineSystem_DBContext context)
        {
            _context = context;
        }
        [RoleManager("GraduatesExpert")]
        public IActionResult Index()
        {
            var students = new FinalGraduatesExpertViewModel()
            {
                FinalGraduatesExpertStudents = _context.FinalGraduatesExpertStudents
                    .Where(s => s.StageStatus == null).Include(s => s.Students).ToList()
            };
            return View("FinalGraduatesExpert", students);
        }

        [RoleManager("GraduatesExpert")]
        [HttpPost]
        public IActionResult SetAsReversed(string studentId, string reversedescribtion)
        {
            var student = _context.Students.Include(s => s.FinalGraduatesExpert).FirstOrDefault(s => s.StudentId == studentId);
            if (student != null)
            {
                student.IsReversed = true;
                student.IsPending = false;
                student.IsFinaled = false;
                student.FinalGraduatesExpert.StageStatus = false;
                student.FinalGraduatesExpert.CheckoutTime = DateTime.Now;
                student.FinalGraduatesExpert.StudentDescribtion = "";
                student.FinalGraduatesExpert.ReverseDescribtion = reversedescribtion;
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

            var student = _context.Students.Include(s => s.FinalGraduatesExpert)

                .FirstOrDefault(s => s.StudentId == studentId);

            student.FinalGraduatesExpert.CheckoutTime = DateTime.Now;
            student.FinalGraduatesExpert.StageStatus = true;
            student.IsFinaled = true;
            student.IsPending = false;
            student.IsReversed = false;
            _context.SaveChanges();
            return Json(true);
        }

        [HttpPost]
        public IActionResult RecheckStudent(string studentId, string studentdescribtion)
        {
            var student = _context.Students.Include(s => s.FinalGraduatesExpert).FirstOrDefault(s => s.StudentId == studentId);
            if (student == null) return Json(false);
            student.IsReversed = false;
            student.IsPending = true;
            student.IsFinaled = false;
            student.FinalGraduatesExpert.StageStatus = null;
            student.FinalGraduatesExpert.StudentDescribtion = studentdescribtion;
            _context.SaveChanges();
            return Json(true);
        }
        [RoleManager("GraduatesExpert")]
        public IActionResult GetHistoryOfStudents()
        {
            var students = new FinalGraduatesExpertViewModel()
            {
                FinalGraduatesExpertStudents = _context.FinalGraduatesExpertStudents.Where(s => s.StageStatus != null).ToList()
            };
            
            return View("FGStudentsHistory", students);
        }
    }
}
