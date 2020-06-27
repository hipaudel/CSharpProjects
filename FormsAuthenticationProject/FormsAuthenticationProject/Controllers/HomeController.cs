using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using System.Web.Mvc;
using FormsAuthenticationProject.Models;

namespace FormsAuthenticationProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeModel _dbcontext = new EmployeeModel();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                bool IsValidUser = _dbcontext.Users.Any(u => u.Username.ToLower() == user.Username.ToLower() && user.Password == user.Password);
                if (IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(user.Username, false);
                    return RedirectToAction("Index", "Employee");
                }
            }
            ModelState.AddModelError("", "invalid Username or Password");
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User registerUser)
        { //comment here
            if (ModelState.IsValid)
            {
                _dbcontext.Users.Add(registerUser);
                _dbcontext.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

    }
}