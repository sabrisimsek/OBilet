using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBiletHelper.Model.Response
{
    public class JourneyResponse
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
        
        [JsonProperty("stops")] 
        public List<StopResponse> Stops { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("departure")]
        public DateTime Departure { get; set; }

        [JsonProperty("arrival")]
        public DateTime Arrival { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("original-price")]
        public double OriginalPrice { get; set; }

        [JsonProperty("internet-price")]
        public double InternetPrice { get; set; }

        [JsonProperty("provider-internet-price")]
        public double? ProviderInternetPrice { get; set; }

        [JsonProperty("booking")]
        public object Booking { get; set; }

        [JsonProperty("bus-name")]
        public string BusName { get; set; }

        [JsonProperty("policy")]
        public PolicyResponse Policy { get; set; }

        [JsonProperty("features")]
        public List<string> Features { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("available")]
        public object Available { get; set; }

        [JsonProperty("partner-provider-code")]
        public object PartnerProviderCode { get; set; }

        [JsonProperty("peron-no")]
        public object PeronNo { get; set; }

        [JsonProperty("partner-provider-id")]
        public object PartnerProviderId { get; set; }

        [JsonProperty("is-segmented")]
        public bool IsSegmented { get; set; }

        [JsonProperty("partner-name")]
        public object PartnerName { get; set; }

        [JsonProperty("provider-code")]
        public object ProviderCode { get; set; }
    }
}
