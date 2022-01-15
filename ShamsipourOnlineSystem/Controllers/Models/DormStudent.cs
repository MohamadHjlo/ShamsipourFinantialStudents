using System;
using System.Collections.Generic;

#nullable disable

namespace ShamsipourOnlineSystem.Models
{
    public partial class DormStudent
    {
        public DormStudent()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string StudentId { get; set; }
        public string ReverseDescribtion { get; set; }
        public string StudentDescribtion { get; set; }
        public bool? StageStatus { get; set; }
        public DateTime? CheckoutTime { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
