using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBiletHelper.Model.Response
{
    public class PolicyResponse
    {
        [JsonProperty("max-seats")]
        public int? Maxseats { get; set; }

        [JsonProperty("max-single")]
        public int? Maxsingle { get; set; }

        [JsonProperty("max-single-males")]
        public int? MaxsingLemales { get; set; }

        [JsonProperty("max-single-females")]
        public int? MaxsingleFemales { get; set; }

        [JsonProperty("mixed-genders")]
        public bool MixedGenders { get; set; }

        [JsonProperty("gov-id")]
        public bool Govid { get; set; }

        [JsonProperty("lht")]
        public bool Lht { get; set; }
    }
}
