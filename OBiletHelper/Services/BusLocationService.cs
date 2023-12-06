using Newtonsoft.Json;
using OBiletHelper.Helper;
using OBiletHelper.Interface;
using OBiletHelper.Model.Request;
using OBiletHelper.Model.Response;
using RestSharp;
using System;

namespace OBiletHelper.Services
{
    public class BusLocationService : IBusLocationService
    {
        public BusLocationsResponse GetBusLocations(BusLocationsRequest request)
        {
            RestClient client = new RestClient(string.Format("{0}{1}", Settings.BaseUrl, Settings.BusLocationRequestUrl));

            RestRequest req = new RestRequest();
            req.AddHeader("Authorization", string.Format("Basic {0}", Settings.ApiClientToken));
            req.AddParameter("application/json", JsonConvert.SerializeObject(request), ParameterType.RequestBody);

            RestResponse result = client.ExecutePost(req);

            return JsonConvert.DeserializeObject<BusLocationsResponse>(result.Content);
        }
    }
}
