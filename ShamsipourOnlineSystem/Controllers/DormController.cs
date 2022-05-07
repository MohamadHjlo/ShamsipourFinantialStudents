using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using ShamsipourOnlineSystem.Data;
using ShamsipourOnlineSystem.Data.Repositories;
using ShamsipourOnlineSystem.Models;
using ShamsipourOnlineSystem.ViewModels;

namespace ShamsipourOnlineSystem.Controllers
{
    [Authorize]
   
    public class DormController : Controller
    {
        private readonly ShamsipourOnlineSystem_DBContext _context;

        public DormController(ShamsipourOnlineSystem_DBContext context)
        {
            _context = context;
        }
        [RoleManager("DormExpert")]
        public IActionResult Index()
        {
            var students = new DormViewModel()
            {
                DormStudents = _context.DormStudents.Where(f => f.StageStatus == null).ToList()
            };
            return View("Dorm", students);

        }
        [RoleManager("DormExpert")]
        [HttpPost]
        public IActionResult SetAsReversed(string studentId, string reversedescribtion)
        {
            var student = _context.Students.Include(s => s.Dorm).Include(s => s.EduExpert).FirstOrDefault(s => s.StudentId == studentId);
            if (student != null)
            {
                student.IsReversed = true;
                student.IsPending = false;
                student.IsFinaled = false;
                student.Dorm.StageStatus = false;
                student.Dorm.StudentDescribtion = "";
                student.Dorm.CheckoutTime = DateTime.Now; 
                student.Dorm.ReverseDescribtion = reversedescribtion;
                _context.SaveChanges();
                return Json(true);
            }
            else
            {
                return Json("nullstates");
            }
        }

        [RoleManager("DormExpert")]
        [HttpPost]
        public IActionResult SetAsSuccessed(string studentId, string studentdescribtion)
        {
            var student = _context.Students
                .Include(s => s.Dorm)
                .Include(s => s.StudentAffairs)
                .Include(s => s.Library)
                .Include(s => s.Laboratory)
                .Include(s => s.ThesisExpert)
                .Include(s => s.Itexpert)
                .FirstOrDefault(s => s.StudentId == studentId);

            var isAnotherStatesAreSuccessed = _context.Students.Where(s => s.StudentId == studentId).Any(s =>
                      s.StudentAffairs.StageStatus == true
                  && s.Library.StageStatus == true
                  && s.Laboratory.StageStatus == true
                  && s.ThesisExpert.StageStatus == true
                  && s.Itexpert.StageStatus == true);

            if (isAnotherStatesAreSuccessed == true)
            {

                var researchAssistantStudent = new ResearchAssistantStudent()
                {
                    StudentId = studentId,
                    StudentDescribtion = studentdescribtion
                };

                _context.ResearchAssistantStudents.Add(researchAssistantStudent);
                _context.SaveChanges();
                student.ResearchAssistantId = researchAssistantStudent.Id;
                _context.SaveChanges();

            }

            student.Dorm.StageStatus = true;
            student.IsFinaled = false;
            student.Dorm.CheckoutTime = DateTime.Now;
            _context.SaveChanges();
            return Json(true);
        }

        [HttpPost]
        public IActionResult RecheckStudent(string studentId, string studentdescribtion)
        {
            var student = _context.Students.Include(s => s.Dorm).FirstOrDefault(s => s.StudentId == studentId);
            if (student == null) return Json(false);
            student.IsReversed = false;
            student.IsPending = true;
            student.IsFinaled = false;
            student.Dorm.StageStatus = null;
            student.Dorm.StudentDescribtion = studentdescribtion;
            _context.SaveChanges();
            return Json(true);

        }
        [RoleManager("DormExpert")]
        public IActionResult GetHistoryOfStudents()
        {
            var students = new DormViewModel()
            {
                DormStudents = _context.DormStudents.Where(s => s.StageStatus != null).ToList()
            };

            return View("DormStudentsHistory", students);
        }
    }
}
