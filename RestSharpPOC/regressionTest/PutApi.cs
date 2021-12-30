using System;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpPOC.Utility;

namespace RestSharpPOC.regressionTest
{
    public class PutApi
    {
     /*   [Test]
        public void performPutApi()
        {
            var client = new RestClient(BaseApi.baseUrl);
            var request = new RestRequest(BaseApi.PUT_API +"{userId}", Method.PUT);
        
            request.AddUrlSegment("userId", 2);

            JObject jobject = new JObject();
            jobject.Add("name", "Hon");
            jobject.Add("job", "CA");

            request.AddBody(jobject);
            request.AddParameter("application/json", jobject, ParameterType.RequestBody);

            

            IRestResponse response = client.Execute(request);

            //print request url
            Console.WriteLine("Response:::" + string.Format(response.ResponseUri.ToString()));
            Console.WriteLine("Response::" + response.StatusDescription);
     
        }*/
    }
}
