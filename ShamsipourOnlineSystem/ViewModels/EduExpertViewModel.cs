using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShamsipourOnlineSystem.Models;

namespace ShamsipourOnlineSystem.ViewModels
{
    public class EduExpertViewModel
    {
        public List<EduExpertStudent> EduExpertStudents { get; set; }

        public List<EduExpertStudent> ReversedStudentsFromGradExpert { get; set; }

        public List<Student> Students { get; set; }

    }
}
