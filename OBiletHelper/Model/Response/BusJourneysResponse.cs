using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBiletHelper.Model.Response
{
    public class BusJourneysResponse : BaseResponse
    {
        [JsonProperty("data")]
        public List<JourneyDataResponse> Data { get; set; }

        [JsonProperty("client-request-id")]
        public object ClientRequestId { get; set; }

        [JsonProperty("web-correlation-id")]
        public object WebCorrelationId { get; set; }

        [JsonProperty("correlation-id")]
        public string CorrelationId { get; set; }

        [JsonProperty("parameters")]
        public object Parameters { get; set; }
    }
}
