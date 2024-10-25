using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Training_RestSharpAutomationFramework.RestClientUtils
{
    public class RestClientUtilities
    {
        //dgfg
        private static RestClient _restClient;
        public static RestClient RestClient
        {
            get
            {
                if (_restClient == null)
                {
                    _restClient = new RestClient(ConfigurationManager.AppSettings["BaseUrl"].ToString());

                }

                return _restClient;
            }
        }
        public static RestClient RestClientWithBasicAuthentication(string username, string password)
        {
            if (_restClient == null)
            {
                _restClient = new RestClient(ConfigurationManager.AppSettings["BaseUrl"].ToString());
                var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
                _restClient.AddDefaultHeader("Authorization", $"Basic {credentials}");
            }
            return _restClient;
        }

        public static RestClient RestClientWithTokenAuthentication(string token)
        {
            if (_restClient == null) 
            {
                _restClient = new RestClient(ConfigurationManager.AppSettings["BaseUrl"].ToString());
                _restClient.AddDefaultHeader("Authorization", $"Bearer {token}");
            }
            return _restClient;
        }
        private static RestRequest CreateRequest(string resource, Method method, DataFormat dataFormat)
        {
            return new RestRequest(resource, method);
             
        }

        //Post
        public static T Post<T>(string resource, string payLoad, DataFormat dataFormat)
        {
            var request = CreateRequest(resource, Method.Post, dataFormat);
            request.AddJsonBody(payLoad);
            RestResponse response = RestClient.Execute(request);
            return JsonConvert.DeserializeObject<T>(response.Content);

        }

        //Delete
        public static bool Delete(string resource, DataFormat dataFormat, HttpStatusCode expectedStatusCode)
        {
            var request = CreateRequest(resource, Method.Delete, dataFormat);
            RestResponse response = RestClient.Execute(request);
            return response.StatusCode == expectedStatusCode;            
        }

        //Get
        public static T Get<T>(string resource, DataFormat dataFormat)
        {
            var request = CreateRequest(resource, Method.Get, dataFormat);
            RestResponse response = RestClient.Execute(request);
            return JsonConvert.DeserializeObject<T>(response.Content);

        }

    }
}
