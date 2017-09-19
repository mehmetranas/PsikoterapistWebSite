﻿using System.Web.Mvc;

namespace PsychotherapistWebSite.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}