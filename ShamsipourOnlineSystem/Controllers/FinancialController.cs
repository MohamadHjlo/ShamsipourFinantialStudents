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
   
    public class FinancialController : Controller
    {
        private readonly ShamsipourOnlineSystem_DBContext _context;

        public FinancialController(ShamsipourOnlineSystem_DBContext context)
        {
            _context = context;
        }
        [RoleManager("FinancialExpert")]
        public IActionResult Index()
        {
            var students = new FinancialViewModel()
            {
                FinancialStudents = _context.FinancialStudents.Where(f => f.StageStatus == null).ToList()
            };
            return View("Financial", students);
        }
        [RoleManager("FinancialExpert")]
        [HttpPost]
        public IActionResult SetAsReversed(string studentId, string reversedescribtion)
        {
            var student = _context.Students.Include(s => s.Financial).FirstOrDefault(s => s.StudentId == studentId);
            if (student != null)
            {
                student.IsReversed = true;
                student.IsPending = false;
                student.IsFinaled = false;
                student.Financial.StageStatus = false;
                student.Financial.CheckoutTime = DateTime.Now;
                student.Financial.StudentDescribtion = "";
                student.Financial.ReverseDescribtion = reversedescribtion;
                _context.SaveChanges();
                return Json(true);
            }
            else
            {
                return Json("nullstates");
            }
        }
        [RoleManager("FinancialExpert")]
        [HttpPost]
        public IActionResult SetAsSuccessed(string studentId, string studentdescribtion)
        {
            var dormStudent = new DormStudent()
            {
                StudentId = studentId,
                StudentDescribtion = studentdescribtion
            };
            var stAffairsStudent = new StudentAffairsStudent()
            {
                StudentId = studentId,
                StudentDescribtion = studentdescribtion
            };
            var libraryStudent = new LibraryStudent()
            {
                StudentId = studentId,
                StudentDescribtion = studentdescribtion
            };
            var laboratoryStudent = new LaboratoryStudent()
            {
                StudentId = studentId,
                StudentDescribtion = studentdescribtion
            };
            var thesisExpertStudent = new ThesisExpertStudent()
            {
                StudentId = studentId,
                StudentDescribtion = studentdescribtion
            };
            var itexpertStudent = new ItexpertStudent()
            {
                StudentId = studentId,
                StudentDescribtion = studentdescribtion
            };
            #region IfNeedToAvoidDuplicateRequest
            //bool isduplicateInDorm = _context.DormStudents.Any(g => g.StudentId == finantialstudent.StudentId);
            //bool isduplicateInStAffairs = _context.StudentAffairsStudents.Any(g => g.StudentId == finantialstudent.StudentId);
            //bool isduplicateInLibrary = _context.LibraryStudents.Any(g => g.StudentId == finantialstudent.StudentId);
            //bool isduplicateInLaboratory = _context.LaboratoryStudents.Any(g => g.StudentId == finantialstudent.StudentId);
            //bool isduplicateInThesis = _context.ThesisExpertStudents.Any(g => g.StudentId == finantialstudent.StudentId);
            //bool isduplicateInIt = _context.ItexpertStudents.Any(g => g.StudentId == finantialstudent.StudentId);
            #endregion

            var student = _context.Students.Include(s => s.Financial)
                .FirstOrDefault(s => s.StudentId == studentId);

            _context.DormStudents.Add(dormStudent);
            _context.StudentAffairsStudents.Add(stAffairsStudent);
            _context.LibraryStudents.Add(libraryStudent);
            _context.LaboratoryStudents.Add(laboratoryStudent);
            _context.ThesisExpertStudents.Add(thesisExpertStudent);
            _context.ItexpertStudents.Add(itexpertStudent);
            _context.SaveChanges();

            student.DormId = dormStudent.Id;
            student.StudentAffairsId = itexpertStudent.Id;
            student.LibraryId = libraryStudent.Id;
            student.LaboratoryId = laboratoryStudent.Id;
            student.ThesisExpertId = thesisExpertStudent.Id;
            student.ItexpertId = itexpertStudent.Id;
            _context.SaveChanges();

            student.Financial.CheckoutTime = DateTime.Now;
            student.Financial.StageStatus = true;
            student.IsFinaled = false;
            student.IsPending = true;
            student.IsReversed = false;
            _context.SaveChanges();
            return Json(true);
        }

        [HttpPost]
        public IActionResult RecheckStudent(string studentId, string studentdescribtion)
        {
            var student = _context.Students.Include(s => s.Financial).FirstOrDefault(s => s.StudentId == studentId);
            if (student == null) return Json(false);
            student.IsReversed = false;
            student.IsPending = true;
            student.IsFinaled = false;
            student.Financial.StageStatus = null;
            student.Financial.StudentDescribtion = studentdescribtion;
            _context.SaveChanges();
            return Json(true);

        }
        [RoleManager("FinancialExpert")]
        public IActionResult GetHistoryOfStudents()
        {
            var students = new FinancialViewModel()
            {
                FinancialStudents = _context.FinancialStudents.Where(s => s.StageStatus != null).ToList()
            };

            return View("FinantialStudentsHistory", students);
        }
    }
}
