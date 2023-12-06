using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBiletHelper.Model.Response
{
    public class SessionResponse : BaseResponse
    {
        [JsonProperty("data")]

        public SessionData Data { get; set; }

    }

}
