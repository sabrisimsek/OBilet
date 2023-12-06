using Newtonsoft.Json;
using OBiletHelper.Helper;
using OBiletHelper.Interface;
using OBiletHelper.Model.Request;
using OBiletHelper.Model.Response;
using RestSharp;

namespace OBiletHelper.Services
{
    public class SessionService: ISessionService
    {
        public SessionResponse GetSession(SessionRequest request)
        {
            RestClient client = new RestClient(string.Format("{0}{1}", Settings.BaseUrl, Settings.SessionRequestUrl));

            RestRequest req = new RestRequest();
            req.AddHeader("Authorization", string.Format("Basic {0}", Settings.ApiClientToken));
            req.AddParameter("application/json", JsonConvert.SerializeObject(request), ParameterType.RequestBody);

            RestResponse result = client.ExecutePost(req);

            return JsonConvert.DeserializeObject<SessionResponse>(result.Content);
        }
    }
}
