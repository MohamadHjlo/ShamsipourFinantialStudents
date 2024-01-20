using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using ShamsipourOnlineSystem.Data;
using ShamsipourOnlineSystem.Models;
using ShamsipourOnlineSystem.ViewModels;

namespace ShamsipourOnlineSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly ShamsipourOnlineSystem_DBContext _context;

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
        public async Task<IActionResult> Register(StudentRegisterViewModel register)
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
                    if (!await _context.Students.AnyAsync(r => r.StudentId == register.StudentId))
                    {
                        await _context.Students.AddAsync(student);
                        await _context.SaveChangesAsync();
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

                    await HttpContext.SignInAsync(principal, properties);

                    return Json(true);
                }
            }
            return Json(false);
        }
        [HttpPost]
        public async Task<IActionResult> ResponsiblesRegister(ResponsibleRegisterViewModel register)
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
                    if (!await _context.Responsibles.AnyAsync(r => r.ResponsibleId == register.ResponsibleId))
                    {
                        await _context.Responsibles.AddAsync(responsible);
                        await _context.SaveChangesAsync();
                        await _context.UserRoles.AddRangeAsync(new List<UserRole>(){new()
                        {

                            UserId = responsible.Id,Role = await _context.Roles.SingleOrDefaultAsync(r=>r.RoleName=="DormExpert")
                        },new (){

                            UserId = responsible.Id,Role = await _context.Roles.SingleOrDefaultAsync(r=>r.RoleName=="EduExpert")
                        },new ()
                        {
                            UserId = responsible.Id,Role = await _context.Roles.SingleOrDefaultAsync(r=>r.RoleName=="GraduatesExpert")

                        },new ()
                        {
                            UserId = responsible.Id,Role = await _context.Roles.SingleOrDefaultAsync(r=>r.RoleName=="FinancialExpert")

                        },new ()
                        {
                            UserId = responsible.Id,Role = await _context.Roles.SingleOrDefaultAsync(r=>r.RoleName=="ItExpert")

                        },new ()
                        {
                            UserId = responsible.Id,Role = await _context.Roles.SingleOrDefaultAsync(r=>r.RoleName=="LaboratoryExpert")

                        },new ()
                        {
                            UserId = responsible.Id,Role = await _context.Roles.SingleOrDefaultAsync(r=>r.RoleName=="LibraryExpert")

                        },new ()
                        {
                            UserId = responsible.Id,Role = await _context.Roles.SingleOrDefaultAsync(r=>r.RoleName=="Manager")

                        },new ()
                            {
                                UserId = responsible.Id,Role = await _context.Roles.SingleOrDefaultAsync(r=>r.RoleName=="ResearchExpert")
                            }
                            ,new ()
                            {
                                UserId = responsible.Id,Role = await _context.Roles.SingleOrDefaultAsync(r=>r.RoleName=="AffairsExpert")
                            }
                            ,new ()
                            {
                                UserId = responsible.Id,Role = await _context.Roles.SingleOrDefaultAsync(r=>r.RoleName=="ThesisExpert")
                            }
                        });
                        await _context.SaveChangesAsync();
                    }


                    var res = await _context.Responsibles.FirstOrDefaultAsync(r => r.ResponsibleId == register.ResponsibleId);

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

                    await HttpContext.SignInAsync(principal, properties);

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
