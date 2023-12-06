using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBiletHelper.Model.Response
{
    public class BusLocationData
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("parent-id")]
        public int ParentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("geo-location")]
        public GeoLocationResponse GeoLocation { get; set; }

        [JsonProperty("tz-code")]
        public string TzCode { get; set; }

        [JsonProperty("weather-code")]
        public string WeatherCode { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("reference-code")]
        public string ReferenceCode { get; set; }

        [JsonProperty("keywords")]
        public string Keywords { get; set; }
    }
}
