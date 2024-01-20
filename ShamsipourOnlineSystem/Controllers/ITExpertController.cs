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
   
    public class ITExpertController : Controller
    {
        private readonly ShamsipourOnlineSystem_DBContext _context;

        public ITExpertController(ShamsipourOnlineSystem_DBContext context)
        {
            _context = context;
        }
        [RoleManager("ItExpert")]
        public IActionResult Index()
        {
            var students = new ITExpertViewModel()
            {
                ItexpertStudents = _context.ItexpertStudents.Where(f => f.StageStatus == null).ToList()
            };
            return View("ITExpert", students);
        }
        [RoleManager("ItExpert")]
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

            bool isAnotherStatesAreSuccessed = _context.Students.Where(s => s.StudentId == studentId)
                .Any(s =>
                s.Dorm.StageStatus == true
                && s.Library.StageStatus == true
                && s.Laboratory.StageStatus == true
                && s.StudentAffairs.StageStatus == true
                && s.ThesisExpert.StageStatus == true);

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
            student.Itexpert.CheckoutTime = DateTime.Now;
            student.Itexpert.StageStatus = true;
            student.IsFinaled = false;
            _context.SaveChanges();
            return Json(true);
        }

        [RoleManager("ItExpert")]
        [HttpPost]
        public IActionResult SetAsReversed(string studentId, string reversedescribtion)
        {
            var student = _context.Students.Include(s => s.Itexpert).FirstOrDefault(s => s.StudentId == studentId);
            if (student != null)
            {
                student.IsReversed = true;
                student.IsPending = false;
                student.IsFinaled = false;
                student.Itexpert.StageStatus = false;
                student.Itexpert.StudentDescribtion = "";
                student.Itexpert.CheckoutTime = DateTime.Now;
                student.Itexpert.ReverseDescribtion = reversedescribtion;
                _context.SaveChanges();
                return Json(true);
            }
            else
            {
                return Json("nullstates");
            }
        }

        [HttpPost]
        public IActionResult RecheckStudent(string studentId, string studentdescribtion)
        {
            var student = _context.Students.Include(s => s.Itexpert).FirstOrDefault(s => s.StudentId == studentId);
            if (student == null) return Json(false);
            student.IsReversed = false;
            student.IsPending = true;
            student.IsFinaled = false;
            student.Itexpert.StageStatus = null;
            student.Itexpert.StudentDescribtion = studentdescribtion;
            _context.SaveChanges();
            return Json(true);

        }
        [RoleManager("ItExpert")]
        public IActionResult GetHistoryOfStudents()
        {
            var students = new ITExpertViewModel()
            {
                ItexpertStudents = _context.ItexpertStudents.Where(s => s.StageStatus != null).ToList()
            };

            return View("ITExpertStudentsHistory", students);
        }
    }
}
