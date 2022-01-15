using System;
using System.Collections.Generic;

#nullable disable

namespace ShamsipourOnlineSystem.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string NationalNo { get; set; }
        public int? EduExpertId { get; set; }
        public int? GraduatesExpertId { get; set; }
        public int? FinancialId { get; set; }
        public int? DormId { get; set; }
        public int? StudentAffairsId { get; set; }
        public int? LibraryId { get; set; }
        public int? LaboratoryId { get; set; }
        public int? ThesisExpertId { get; set; }
        public int? ItexpertId { get; set; }
        public int? ResearchAssistantId { get; set; }
        public int? FinalGraduatesExpertId { get; set; }
        public bool? IsReversed { get; set; }
        public bool? IsPending { get; set; }
        public bool? IsFinaled { get; set; }
        public DateTime? RequestTime { get; set; }

        public virtual DormStudent Dorm { get; set; }
        public virtual EduExpertStudent EduExpert { get; set; }
        public virtual FinalGraduatesExpertStudent FinalGraduatesExpert { get; set; }
        public virtual FinancialStudent Financial { get; set; }
        public virtual GraduatesExpertStudent GraduatesExpert { get; set; }
        public virtual ItexpertStudent Itexpert { get; set; }
        public virtual LaboratoryStudent Laboratory { get; set; }
        public virtual LibraryStudent Library { get; set; }
        public virtual ResearchAssistantStudent ResearchAssistant { get; set; }
        public virtual StudentAffairsStudent StudentAffairs { get; set; }
        public virtual ThesisExpertStudent ThesisExpert { get; set; }
    }
}
