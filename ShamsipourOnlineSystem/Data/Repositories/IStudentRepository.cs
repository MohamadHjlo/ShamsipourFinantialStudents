using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ShamsipourOnlineSystem.ViewModels;

namespace ShamsipourOnlineSystem.Data.Repositories
{
    public interface IStudentRepository
    {
        public StudentStatusViewModel GetStudentStatusHistory(string studentId);
    }

    public class StudentReposiroty : IStudentRepository
    {

        private ShamsipourOnlineSystem_DBContext _context;

        public StudentReposiroty(ShamsipourOnlineSystem_DBContext context)
        {
            _context = context;
        }


        public StudentStatusViewModel GetStudentStatusHistory(string studentId)
        {

            var student = _context.Students.SingleOrDefault(s => s.StudentId == studentId);

            if (student==null)
            {
                return new StudentStatusViewModel();
            }

            var model = new StudentStatusViewModel()
            {
                Student = student
            };
            if (model.Student.EduExpertId != null)
            {
                var st = _context.EduExpertStudents.FirstOrDefault(s =>
                    s.StudentId == studentId && s.Id == model.Student.EduExpertId);
                model.IsEduIsPending = true;
                model.EduStage=st;
                model.EduStage.StageStatus = st.StageStatus;
                model.EduStage.CheckoutTime = st
                    .CheckoutTime;
                model.EduStage.ReverseDescribtion=st.ReverseDescribtion;
                model.EduStage.ReverseDescribtion=st.ReverseDescribtion;
                st = null;
            }

            if (model.Student.GraduatesExpertId != null)
            {
                var st = _context.GraduatesExpertStudents.FirstOrDefault(s =>
                     s.StudentId == studentId && s.Id == model.Student.GraduatesExpertId);
                model.GradStage = st;
                model.IsGradIsPending = true;
                model.GradStage.StageStatus = st
                    .StageStatus;
                model.GradStage.CheckoutTime = st
                    .CheckoutTime;
                model.GradStage.ReverseDescribtion = st.ReverseDescribtion;
                model.GradStage.ReverseDescribtion = st.ReverseDescribtion;
                st = null;
            }
            if (model.Student.FinancialId != null)
            {
                var st = _context.FinancialStudents.FirstOrDefault(s =>
                     s.StudentId == studentId && s.Id == model.Student.FinancialId);
                model.FinantialStage = st;
                model.IsfinantialIsPending = true;
                model.FinantialStage.StageStatus = st
                    .StageStatus;
                model.FinantialStage.CheckoutTime = st
                    .CheckoutTime;
                model.FinantialStage.ReverseDescribtion = st.ReverseDescribtion;
                model.FinantialStage.ReverseDescribtion = st.ReverseDescribtion;
                st = null;

            }
            if (model.Student.DormId != null)
            {
                var st = _context.DormStudents.FirstOrDefault(s =>
                     s.StudentId == studentId && s.Id == model.Student.DormId);
                model.DormStage = st;
                model.IsDormIsPending = true;
                model.DormStage.StageStatus = st
                    .StageStatus;
                model.DormStage.CheckoutTime = st
                    .CheckoutTime;
                model.DormStage.ReverseDescribtion = st.ReverseDescribtion;
                model.DormStage.ReverseDescribtion = st.ReverseDescribtion;
                st = null;
            }
            if (model.Student.StudentAffairsId != null)
            {
                var st = _context.StudentAffairsStudents.FirstOrDefault(s =>
                    s.StudentId == studentId && s.Id == model.Student.StudentAffairsId);
                model.AffairsStage = st;
                model.IsAffairsIsPending = true;
                model.AffairsStage.StageStatus = st
                    .StageStatus;
                model.AffairsStage.CheckoutTime = st
                    .CheckoutTime;
                model.AffairsStage.ReverseDescribtion = st.ReverseDescribtion;
                model.AffairsStage.ReverseDescribtion = st.ReverseDescribtion;
                st = null;
            }
            if (model.Student.LibraryId != null)
            {
                var st = _context.LibraryStudents.FirstOrDefault(s =>
                     s.StudentId == studentId && s.Id == model.Student.LibraryId);
                model.LibraryStage = st;
                model.IsLibraryIsPending = true;
                model.LibraryStage.StageStatus = st.StageStatus;
                model.LibraryStage.CheckoutTime = st.CheckoutTime;
                model.LibraryStage.ReverseDescribtion = st.ReverseDescribtion;
                model.LibraryStage.ReverseDescribtion = st.ReverseDescribtion;
                st = null;
            }
            if (model.Student.LaboratoryId != null)
            {
                var st = _context.LaboratoryStudents.FirstOrDefault(s =>
                     s.StudentId == studentId && s.Id == model.Student.LaboratoryId);
                model.LaboratoryStage = st;
                model.IsLaboratoryIsPending = true;
                model.LaboratoryStage.StageStatus = st.StageStatus;
                model.LaboratoryStage.CheckoutTime = st.CheckoutTime;
                model.LaboratoryStage.ReverseDescribtion = st.ReverseDescribtion;
                model.LaboratoryStage.ReverseDescribtion = st.ReverseDescribtion;
                st = null;
            }
            if (model.Student.ThesisExpertId != null)
            {
                var st = _context.ThesisExpertStudents.FirstOrDefault(s =>
                    s.StudentId == studentId && s.Id == model.Student.ThesisExpertId);
                model.ThesisStage = st;
                model.IsThesisIsPending = true;
                model.ThesisStage.StageStatus = st.StageStatus;
                model.ThesisStage.CheckoutTime = st.CheckoutTime;
                model.ThesisStage.ReverseDescribtion = st.ReverseDescribtion;
                st = null;
            }
            if (model.Student.ItexpertId != null)
            {
                var st = _context.ItexpertStudents.FirstOrDefault(s =>
                     s.StudentId == studentId && s.Id == model.Student.ItexpertId);
                model.ITStage = st;
                model.IsItIsPending = true;
                model.ITStage.StageStatus = st.StageStatus;
                model.ITStage.CheckoutTime = st.CheckoutTime;
                model.ITStage.ReverseDescribtion = st.ReverseDescribtion;
                model.ITStage.ReverseDescribtion = st.ReverseDescribtion;
                st = null;
            }
            if (model.Student.ResearchAssistantId != null)
            {
                var st = _context.ResearchAssistantStudents.FirstOrDefault(s =>
                     s.StudentId == studentId && s.Id == model.Student.ResearchAssistantId);
                model.ResearchStage = st;
                model.IsRessearchIsPending = true;
                model.ResearchStage.StageStatus = st.StageStatus;
                model.ResearchStage.CheckoutTime = st.CheckoutTime;
                model.ResearchStage.ReverseDescribtion = st.ReverseDescribtion;
                model.ResearchStage.ReverseDescribtion = st.ReverseDescribtion;
                st = null;
            }
            if (model.Student.FinalGraduatesExpertId != null)
            {
                var st = _context.FinalGraduatesExpertStudents.FirstOrDefault(s =>
                    s.StudentId == studentId && s.Id == model.Student.FinalGraduatesExpertId);
                model.FinalGradStage = st;
                model.IsFGradIsPending = true;
                model.FinalGradStage.StageStatus = st.StageStatus;
                model.FinalGradStage.CheckoutTime = st.CheckoutTime;
                model.FinalGradStage.ReverseDescribtion = st.ReverseDescribtion;
                model.FinalGradStage.ReverseDescribtion = st.ReverseDescribtion;
                st = null;
            }

            return model;
        }
    }
}
