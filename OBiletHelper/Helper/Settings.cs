using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBiletHelper.Helper
{
    public static class Settings
    {
        public static string ApiClientToken { get { return "JEcYcEMyantZV095WVc3G2JtVjNZbWx1"; } }
        public static string BaseUrl { get { return "https://v2-api.obilet.com/api"; } }
        public static string SessionRequestUrl { get { return "/client/getsession"; } }
        public static string BusJourneyRequestUrl { get { return "/journey/getbusjourneys"; } }
        public static string BusLocationRequestUrl { get { return "/location/getbuslocations"; } }

    }
}
