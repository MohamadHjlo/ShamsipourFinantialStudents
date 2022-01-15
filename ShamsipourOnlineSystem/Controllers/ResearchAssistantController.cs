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
  
    public class ResearchAssistantController : Controller
    {
        private ShamsipourOnlineSystem_DBContext _context;

        public ResearchAssistantController(ShamsipourOnlineSystem_DBContext context)
        {
            _context = context;
        }
        [RoleManager("ResearchExpert")]
        public IActionResult Index()
        {
            var students = new ResearchAssistantViewModel()
            {
                ResearchAssistantStudents = _context.ResearchAssistantStudents
                    .Where(s => s.StageStatus == null).Include(s => s.Students).ToList()
            };
            return View("ResearchAssistant", students);
        }
        [RoleManager("ResearchExpert")]
        [HttpPost]
        public IActionResult SetAsReversed(string studentId, string reversedescribtion)
        {
            var student = _context.Students.Include(s => s.ResearchAssistant).FirstOrDefault(s => s.StudentId == studentId);
            if (student != null)
            {
                student.IsReversed = true;
                student.IsPending = false;
                student.IsFinaled = false;
                student.ResearchAssistant.StageStatus = false;
                student.ResearchAssistant.StudentDescribtion = "";
                student.ResearchAssistant.ReverseDescribtion = reversedescribtion;
                student.ResearchAssistant.CheckoutTime=DateTime.Now;
                _context.SaveChanges();
                return Json(true);
            }
            else
            {
                return Json("nullstates");
            }
        }
        [RoleManager("ResearchExpert")]
        [HttpPost]
        public IActionResult SetAsSuccessed(string studentId, string studentdescribtion)
        {
            var finalGradStudent = new FinalGraduatesExpertStudent()
            {
                StudentId = studentId,
                StudentDescribtion = studentdescribtion
            };

            var student = _context.Students.Include(s => s.ResearchAssistant)
                .Include(s => s.FinalGraduatesExpert)
                .FirstOrDefault(s => s.StudentId == studentId);

            _context.FinalGraduatesExpertStudents.Add(finalGradStudent);
            _context.SaveChanges();
            student.FinalGraduatesExpertId = finalGradStudent.Id;
            _context.SaveChanges();
            student.ResearchAssistant.CheckoutTime = DateTime.Now;
            student.ResearchAssistant.StageStatus = true;
            student.IsFinaled = false;
            _context.SaveChanges();
            return Json(true);
        }

        [HttpPost]
        public IActionResult RecheckStudent(string studentId, string studentdescribtion)
        {
            var student = _context.Students.Include(s => s.ResearchAssistant).FirstOrDefault(s => s.StudentId == studentId);
            if (student == null) return Json(false);
            student.IsReversed = false;
            student.IsPending = true;
            student.IsFinaled = false;
            student.ResearchAssistant.StageStatus = null;
            student.ResearchAssistant.StudentDescribtion = studentdescribtion;
            _context.SaveChanges();
            return Json(true);
        }
        [RoleManager("ResearchExpert")]
        public IActionResult GetHistoryOfStudents()
        {
            var students = new ResearchAssistantViewModel()
            {
                ResearchAssistantStudents = _context.ResearchAssistantStudents.Where(s => s.StageStatus != null).ToList()
            };

            return View("ResearchAssistantStudentsHistory", students);
        }
    }
}
