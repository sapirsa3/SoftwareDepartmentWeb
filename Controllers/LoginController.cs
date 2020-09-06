using projectnetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projectnetwork.Dal;
using projectnetwork.ModelView;

namespace projectnetwork.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginPage()
        {
            return View(new Login());
        }


     
        [HttpPost]
        public ActionResult Submit(Login log)
        {
            LoginDal dal = new LoginDal();
            LoginDal dal1 = new LoginDal();
            Userview user = new Userview();
            String username1 = log.Username;
            String password = log.Password;
            List<Login> objectus = 
                (from x in dal.Userslogin
                 where x.Username == username1 && x.Password == password select x).ToList<Login>();

            if (ModelState.IsValid && objectus.Count==1)
            {
                ViewBag.Current = user;
                user.Login_Use = objectus.First<Login>();

                if (user.Login_Use.Permmision.Equals("Admin"))
                {

                    Session["User"] = username1;
                    Session["Pass"] = password;
                    Session["Per"] = "Admin";

                    return RedirectToRoute ("Startpageadmin");
                }
                if (user.Login_Use.Permmision.Equals("Lecturer"))
                {
                    return View("Present2", log);
                }
                if (user.Login_Use.Permmision.Equals("Student"))
                {
                    return View("Present3", log);
                }

            }
            dal.SaveChanges();
            dal1.SaveChanges();
            return View("LoginPage",log);
        }
    }
}