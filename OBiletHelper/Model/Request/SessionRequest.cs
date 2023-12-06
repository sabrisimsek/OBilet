using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBiletHelper.Model.Request
{
    public class SessionRequest
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("connection")]
        public ConnectionRequest Connection { get; set; }

        [JsonProperty("browser")]
        public BrowserRequest Browser { get; set; }
    }
}
