using System;
using AventStack.ExtentReports;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpPOC.Model;
using RestSharpPOC.Utility;

namespace RestSharpPOC.regressionTest
{
    [TestFixture]
    public class PostApi
    {

      

        [Test]
        public void postApiTest ()
        {
            ExtentReports obj = Reporter.GetInstance();
            ExtentTest test;
            test = obj.CreateTest("Post Api");
         
            // ExtentTest test = Reporter.extent.CreateTest("Post Api").Info("Test case start for Post Api");

            var client = new RestClient(BaseApi.baseUrl);
            var request = new RestRequest(BaseApi.POST_API, Method.POST);

            //using getter and setter
            /*    request.RequestFormat = DataFormat.Json;
                request.AddBody(new User() { name = "Nick", job = "Lead" });

                request.OnBeforeDeserialization = response => { response.ContentType = "application/json"; };

                IRestResponse response = client.Execute(request);

                Console.WriteLine("Response Message::::" + response.StatusDescription);*/

            //add body as object -1

            /*      JObject jobject = new JObject();
                  jobject.Add("name", "Honey");
                  jobject.Add("job", "CA");*/

            // add body object -2
            UserObject userObject = new UserObject();
            JObject jobject = userObject.setUserObject();

            request.AddParameter("application/json", jobject, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine("Response Description::" + response.StatusDescription);
            test.Log(Status.Pass);
            obj.Flush();
          
            /* Add Query param in request
             * 
             * request.AddQueryParameter("save", "true");
                    request.AddQueryParameter("UserId", "5355234");*/
        }
    }
}
