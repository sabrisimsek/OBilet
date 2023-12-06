using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBiletHelper.Model.Request
{
    public class BusLocationsRequest : BaseRequest
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
