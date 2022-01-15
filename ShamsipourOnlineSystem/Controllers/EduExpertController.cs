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

    public class EduExpertController : Controller
    {

        private ShamsipourOnlineSystem_DBContext _context;

        public EduExpertController(ShamsipourOnlineSystem_DBContext context)
        {
            _context = context;
        }
        [RoleManager("EduExpert")]
        public IActionResult Index()
        {
            var students = new EduExpertViewModel()
            {
                EduExpertStudents = _context.EduExpertStudents
                    .Where(s => s.IsReversedFromGradExpert != true && s.StageStatus == null)
                    .Include(s => s.Students).ToList(),
                ReversedStudentsFromGradExpert = _context.EduExpertStudents
                    .Where(s => s.IsReversedFromGradExpert == true).ToList()
            };
            return View("EduExpert", students);
        }
        [RoleManager("EduExpert")]
        [HttpPost]
        public IActionResult SetAsReversed(string studentId, string reversedescribtion)
        {
            var student = _context.Students.Include(s => s.EduExpert).FirstOrDefault(s => s.StudentId == studentId);
            if (student != null)
            {
                student.IsReversed = true;
                student.IsPending = false;
                student.IsFinaled = false;
                student.EduExpert.StageStatus = false;
                student.EduExpert.CheckoutTime = DateTime.Now;
                student.EduExpert.StudentDescribtion = "";
                student.EduExpert.ReverseDescribtion = reversedescribtion;
                _context.SaveChanges();
                return Json(true);
            }
            else
            {
                return Json("nullstates");
            }
        }

        [RoleManager("EduExpert")]
        [HttpPost]
        public IActionResult SetAsSuccessed(string studentId, string studentdescribtion)
        {
            var gradstudent = new GraduatesExpertStudent()
            {
                StudentId = studentId,
                StudentDescribtion = studentdescribtion
            };

            bool isduplicate = _context.GraduatesExpertStudents.Any(g => g.StudentId == gradstudent.StudentId);

            var student = _context.Students.Include(s => s.EduExpert)
                .Include(s => s.GraduatesExpert)
                .FirstOrDefault(s => s.StudentId == studentId);

            if (!isduplicate)
            {
                _context.GraduatesExpertStudents.Add(gradstudent);
                _context.SaveChanges();
                student.GraduatesExpertId = gradstudent.Id;
                _context.SaveChanges();
            }
            student.EduExpert.CheckoutTime = DateTime.Now;
            student.EduExpert.StageStatus = true;
            student.EduExpert.IsReversedFromGradExpert = null;
            student.GraduatesExpert.StageStatus = null;
            student.IsFinaled = false;
            student.IsPending = true;
            student.IsReversed = false;
            _context.SaveChanges();
            return Json(true);
        }


        [HttpPost]
        public IActionResult RecheckStudent(string studentId, string studentdescribtion)
        {
            var student = _context.Students.Include(s => s.EduExpert).FirstOrDefault(s => s.StudentId == studentId);
            if (student == null) return Json(false);
            student.IsReversed = false;
            student.IsPending = true;
            student.IsFinaled = false;
            student.EduExpert.StageStatus = null;
            student.EduExpert.StudentDescribtion = studentdescribtion;
            _context.SaveChanges();
            return Json(true);

        }
        [RoleManager("EduExpert")]
        public IActionResult GetHistoryOfStudents()
        {
            var students = new EduExpertViewModel()
            {
                EduExpertStudents = _context.EduExpertStudents.Where(s => s.StageStatus != null).Include(s => s.Students).ToList()
            };


            return View("EduStudentsHistory", students);
        }
    }
}
