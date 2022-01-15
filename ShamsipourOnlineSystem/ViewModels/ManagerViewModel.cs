using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShamsipourOnlineSystem.Models;

namespace ShamsipourOnlineSystem.ViewModels
{
    public class ManagerViewModel
    {
        public List<Student> Students { get; set; }

        public int CurrentPage { get; set; }
        public int PageSize { get; set; }

        public int TotalRecords { get; set; }
    }
}
