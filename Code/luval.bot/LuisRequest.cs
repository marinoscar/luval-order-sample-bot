using luval.bot.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.bot
{
    public class LuisRequest : ILuisRequest
    {

        public LuisRequest(LuisSession session)
        {
            Session = session;
        }

        public LuisSession Session { get; private set; }

        public LuisQueryResult RunQuery(string query)
        {
            var response = ExecuteRequest(query);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                throw new LuisRequestException(string.Format("Failed to execute the request, error {0} status {1} and content {2}", 
                    response.ErrorMessage, response.StatusCode, response.Content));
            return response.Data;
        }

        protected virtual IRestResponse<LuisQueryResult> ExecuteRequest(string query)
        {
            var client = new RestClient(new Uri(Session.Endpoint));
            var request = new RestRequest("apps/{appid}", Method.GET);
            request.AddUrlSegment("appid", Session.AppId);
            request.AddParameter("staging", Session.IsStaging);
            request.AddParameter("verbose", Session.IsVerbose);
            request.AddParameter("timezoneOffset", Session.TimeZoneOffset);
            request.AddParameter("subscription-key", Session.Key);
            request.AddParameter("q", query);
            var res = client.Execute<LuisQueryResult>(request);
            return res;
        }

    }
}
