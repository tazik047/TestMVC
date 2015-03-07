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
            var login = Session["user"] as OldUser;
            return View("Index", login);
        }

        public ActionResult Login(OldUser user)
        {
            if (!ModelState.IsValid)
                return View("Index");
            if ((Session["user"] as OldUser)== null)
            {
                Session["user"] = user;
                return View("Index", user);
            }
            return RedirectToAction("Index");
        }

    }
}
