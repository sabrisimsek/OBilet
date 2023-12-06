using OBiletHelper.Model.Request;
using OBiletHelper.Services;
using OBiletUI.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OBiletUI.Controllers
{
    [Session]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}