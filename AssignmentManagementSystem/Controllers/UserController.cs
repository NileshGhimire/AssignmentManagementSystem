using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssignmentManagementSystem.Models;

namespace AssignmentManagementSystem.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            using(OurDbContext db = new OurDbContext())
            {
                return View(db.Users.ToList());
            }
        }
       
        // signup   
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User users)
        {
            if (ModelState.IsValid)
            {
                using (OurDbContext db = new OurDbContext())
                {
                    db.Users.Add(users);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = users.FirstName + "" + users.LastName + "Your Account Has Been Created";
            }
            return View();
        }
        //Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User users)
        {
            using (OurDbContext db = new OurDbContext())
            {
                var usr = db.Users.FirstOrDefault(u => u.UserName == users.UserName && u.Password == users.Password);
                if (usr != null)
                {
                    Session["Userid"] = usr.Userid;
                    Session["UserName"] = usr.UserName;
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "UserName or Password is Incorrect. Please Try Again");
                }
            }
                return View();
            }
            public ActionResult LoggedIn()
            {
                if (Session["Userid"] != null)
                {
                    return View("../Home/Index");
                }
                else
                {
                    return RedirectToAction("Login");
                }
            }
        }
    }
