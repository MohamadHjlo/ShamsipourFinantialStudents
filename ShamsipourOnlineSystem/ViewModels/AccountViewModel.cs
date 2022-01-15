using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShamsipourOnlineSystem.ViewModels
{
    public class StudentRegisterViewModel
    {
       
        [Display(Name = "شماره دانشجویی: ")]
        public string StudentId { get; set; }

       
        [Display(Name = "کد ملی: ")]
        public string NationalNo { get; set; }
    }

    public class ResponsibleRegisterViewModel
    {

        [Display(Name = "شماره شناسایی: ")]
        public string ResponsibleId { get; set; }


        [Display(Name = "کد ملی: ")]
        public string NationalNo { get; set; }
    }
}
