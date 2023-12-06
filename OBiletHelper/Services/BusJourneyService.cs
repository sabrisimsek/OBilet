using Newtonsoft.Json;
using OBiletHelper.Helper;
using OBiletHelper.Interface;
using OBiletHelper.Model.Request;
using OBiletHelper.Model.Response;
using RestSharp;
using System;

namespace OBiletHelper.Services
{
    public class BusJourneyService : IBusJourneyService
    {
        public BusJourneysResponse GetJourneys(BusJourneysRequest request)
        {
            RestClient client = new RestClient(string.Format("{0}{1}", Settings.BaseUrl, Settings.BusJourneyRequestUrl));

            RestRequest req = new RestRequest();
            req.AddHeader("Authorization", string.Format("Basic {0}", Settings.ApiClientToken));
            req.AddParameter("application/json", JsonConvert.SerializeObject(request), ParameterType.RequestBody);

            RestResponse result = client.ExecutePost(req);

            return JsonConvert.DeserializeObject<BusJourneysResponse>(result.Content);
        }
    }
}
