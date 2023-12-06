using OBiletHelper.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OBiletUI.Helper;
using System.Web.Helpers;
using OBiletHelper.Model.Response;

namespace OBiletUI.Controllers
{
    [Session]
    public class BusJourneysController : Controller
    {
        private readonly IBusJourneyService _busJourneyService;

        public BusJourneysController(IBusJourneyService busJourneyService)
        {
            _busJourneyService = busJourneyService;
        }
        public ActionResult GetBusJourney(DateTime departureDate, int destinationId, int originId)
        {
            var session = HttpContext.Session["Session"] as SessionResponse;

            var response = _busJourneyService.GetJourneys(new OBiletHelper.Model.Request.BusJourneysRequest()
            {
                Data = new OBiletHelper.Model.Request.BusJourneysDataRequest()
                {
                    DepartureDate = departureDate.ToString("yyyy-MM-dd"),
                    DestinationId = destinationId ,
                    OriginId = originId 
                },
                DeviceSession = new OBiletHelper.Model.Request.DeviceSessionRequest()
                {
                    DeviceId = session.Data.DeviceId,
                    SessionId = session.Data.SessionId
                },
                Date = departureDate.ToString("yyyy-MM-dd"),
                Language = "tr-TR"
            });

            return View(response);
        }

    }
}