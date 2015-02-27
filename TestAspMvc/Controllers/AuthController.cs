using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TestAspMvc.Models;

namespace TestAspMvc.Controllers
{
    public class AuthController : Controller
    {
        //
        // GET: /Auth/

        public ActionResult Index()
        {
            var login = Session["user"] as User;
            return View("Index", login);
        }

        public ActionResult Login(User user)
        {
            if ((Session["user"] as User)== null)
            {
                Session["user"] = user;
                return View("Index", user);
            }
            return RedirectToAction("Index");
        }

    }
}
