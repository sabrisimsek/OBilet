using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBiletHelper.Model.Request
{
    public class BaseRequest
    {
        [JsonProperty("device-session")]
        public DeviceSessionRequest DeviceSession { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }
}
