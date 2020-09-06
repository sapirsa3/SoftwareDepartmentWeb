using projectnetwork.Dal;
using projectnetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projectnetwork.Controllers
{
    public class AdminController : Controller
    {
        // GET: Student


        public ActionResult Startpageadmin()
        {

            return View(new Admin());

        }

        public ActionResult Adduser()
        {
            return View();
        }


        public ActionResult Submit(Admin admin)
        {

            LoginDal dal = new LoginDal();

            //Userview user = new Userview();
            String id = admin.Id;
            String firstname = admin.FirstName;
            String lastname = admin.LastName;
            String permission = admin.Permmision;
            String password = admin.Password;
            String username = admin.UserName;
            List<Admin> objectus =
                 (from x in dal.Users
                  where x.Id == id
                  select x).ToList<Admin>();
            if (ModelState.IsValid)
            {
                dal.Users.Add(admin);
                dal.SaveChanges();
            }
            return View("Adduser", admin);

        }

    }
}