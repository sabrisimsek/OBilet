using OBiletHelper.Interface;
using OBiletHelper.Model.Response;
using OBiletUI.Helper;
using OBiletUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OBiletUI.Controllers
{
    [Session]
    public class BusLocationController : Controller
    {
        private readonly IBusLocationService _busLocationService;
        public BusLocationController(IBusLocationService busLocationService)
        {
            _busLocationService = busLocationService;
        }

        [HttpGet]
        public JsonResult GetBusLocation(string text, DateTime date)
        {
            var session = Session["Session"] as SessionResponse;
            var response = _busLocationService.GetBusLocations(
                 new OBiletHelper.Model.Request.BusLocationsRequest()
                 {
                     Data = text,
                     DeviceSession = new OBiletHelper.Model.Request.DeviceSessionRequest()
                     {
                         DeviceId = session?.Data.DeviceId,
                         SessionId = session?.Data.SessionId,
                     },
                     Language = "tr-TR",
                     Date = date.ToString("yyyyy-MM-dd")
                 });
            return Json(response.Data.Take(7).ToList(), JsonRequestBehavior.AllowGet);

        }
    }
}