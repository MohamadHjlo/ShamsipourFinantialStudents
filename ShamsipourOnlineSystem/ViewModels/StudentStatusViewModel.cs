using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShamsipourOnlineSystem.Models;

namespace ShamsipourOnlineSystem.ViewModels
{
    public class StudentStatusViewModel
    {
        public Student Student { get; set; }
        public EduExpertStudent EduStage { get; set; }
        public bool IsEduIsPending { get; set; }

        public GraduatesExpertStudent GradStage { get; set; }
        public bool IsGradIsPending { get; set; }

        public FinancialStudent FinantialStage { get; set; }
        public bool IsfinantialIsPending { get; set; }

        public DormStudent DormStage { get; set; }
        public bool IsDormIsPending { get; set; }

        public StudentAffairsStudent AffairsStage { get; set; }
        public bool IsAffairsIsPending { get; set; }

        public LibraryStudent LibraryStage { get; set; }
        public bool IsLibraryIsPending { get; set; }

        public LaboratoryStudent LaboratoryStage { get; set; }
        public bool IsLaboratoryIsPending { get; set; }

        public ThesisExpertStudent ThesisStage { get; set; }
        public bool IsThesisIsPending { get; set; }

        public ItexpertStudent ITStage { get; set; }
        public bool IsItIsPending { get; set; }

        public ResearchAssistantStudent ResearchStage { get; set; }
        public bool IsRessearchIsPending { get; set; }

        public FinalGraduatesExpertStudent FinalGradStage { get; set; }
        public bool IsFGradIsPending { get; set; }
    }
}
