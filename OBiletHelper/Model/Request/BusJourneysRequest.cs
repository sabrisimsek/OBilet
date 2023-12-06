using Newtonsoft.Json;
using OBiletHelper.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBiletHelper.Model.Request
{
    public class BusJourneysRequest : BaseRequest
    {
        [JsonProperty("data")]
        public BusJourneysDataRequest Data { get; set; }

    }
}
