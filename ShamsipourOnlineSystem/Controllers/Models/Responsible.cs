using System;
using System.Collections.Generic;

#nullable disable

namespace ShamsipourOnlineSystem.Models
{
    public partial class Responsible
    {
        public Responsible()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string ResponsibleId { get; set; }
        public string NationalNo { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
