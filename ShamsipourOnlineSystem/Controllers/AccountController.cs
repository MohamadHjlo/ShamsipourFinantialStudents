using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using ShamsipourOnlineSystem.Data;
using ShamsipourOnlineSystem.Models;
using ShamsipourOnlineSystem.ViewModels;

namespace ShamsipourOnlineSystem.Controllers
{
    public class AccountController : Controller
    {
        private ShamsipourOnlineSystem_DBContext _context;

        public AccountController(ShamsipourOnlineSystem_DBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View("/Views/Home/Account.cshtml");
        }

        public IActionResult Register()
        {
            return View("/Views/Home/Account.cshtml");
        }
        public IActionResult ResponsiblesRegister()
        {
            return View("/Views/Home/ResponsiblesRegister.cshtml");
        }

        [HttpPost]
        public IActionResult Register(StudentRegisterViewModel register)
        {
            if (register.NationalNo != null && register.StudentId != null)
            {
                if (register.StudentId.Length == 14 && register.NationalNo.Length == 10)
                {
                    var student = new Student()
                    {
                        StudentId = register.StudentId,
                        NationalNo = register.NationalNo,
                    };
                    if (!_context.Students.Any(r => r.StudentId == register.StudentId))
                    {
                        _context.Students.Add(student);
                        _context.SaveChanges();
                    }

                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier,student.StudentId.ToString()),
                    new Claim("ID",student.Id.ToString()),
                    new Claim("NationalNo",student.NationalNo.ToString()),

                };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = true
                    };

                    HttpContext.SignInAsync(principal, properties);

                    return Json(true);
                }
            }
            return Json(false);
        }
        [HttpPost]
        public IActionResult ResponsiblesRegister(ResponsibleRegisterViewModel register)
        {
            if (register.NationalNo != null && register.ResponsibleId != null)
            {
                if (register.ResponsibleId.Length == 14 && register.NationalNo.Length == 10)
                {
                    var responsible = new Responsible()
                    {
                        ResponsibleId = register.ResponsibleId,
                        NationalNo = register.NationalNo

                    };
                    if (!_context.Responsibles.Any(r => r.ResponsibleId == register.ResponsibleId))
                    {
                        _context.Responsibles.Add(responsible);
                        _context.SaveChanges();
                    }


                    var res = _context.Responsibles.FirstOrDefault(r => r.ResponsibleId == register.ResponsibleId);

                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier,responsible.ResponsibleId.ToString()),
                        new Claim("ID",res.Id.ToString()),
                        new Claim("NationalNo",res.NationalNo.ToString()),
                        new Claim("IsResponsible","true")
                    };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = true
                    };

                    HttpContext.SignInAsync(principal, properties);

                    return Json(true);
                }
            }
            return Json(false);
        }

        [HttpPost]
        public IActionResult CheckIdInput(string id)
        {

            if (id == null || id.ToString().Length != 14)
            {
                return Json(false);
            }

            return Json(true);

        }
        [HttpPost]
        public IActionResult CheckNationalNoInput(string nationalNo)
        {

            if (nationalNo == null || nationalNo.ToString().Length != 10)
            {
                return Json(false);
            }

            return Json(true);
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Account/Register");
        }
    }
}
