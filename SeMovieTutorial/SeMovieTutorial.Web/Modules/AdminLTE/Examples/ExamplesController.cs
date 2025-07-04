﻿
namespace SeMovieTutorial.AdminLTE
{
    using System.Web.Mvc;

    [Authorize, RoutePrefix("AdminLTE/Examples"), Route("{action=index}")]
    public class ExamplesController : Controller
    {
        public ActionResult BlankPage()
        {
            return View(MVC.Views.AdminLTE.Examples.BlankPage);
        }

        public ActionResult Error404()
        {
            return View(MVC.Views.AdminLTE.Examples.Error404);
        }

        public ActionResult Error500()
        {
            return View(MVC.Views.AdminLTE.Examples.Error500);
        }

        public ActionResult Invoice()
        {
            return View(MVC.Views.AdminLTE.Examples.Invoice);
        }

        public ActionResult InvoicePrint()
        {
            return View(MVC.Views.AdminLTE.Examples.InvoicePrint);
        }

        public ActionResult Lockscreen()
        {
            return View(MVC.Views.AdminLTE.Examples.Lockscreen);
        }

        public ActionResult Login()
        {
            return View(MVC.Views.AdminLTE.Examples.Login);
        }

        public ActionResult PacePage()
        {
            return View(MVC.Views.AdminLTE.Examples.PacePage);
        }

        public new ActionResult Profile()
        {
            return View(MVC.Views.AdminLTE.Examples.Profile);
        }

        public ActionResult Register()
        {
            return View(MVC.Views.AdminLTE.Examples.Register);
        }
    }
}