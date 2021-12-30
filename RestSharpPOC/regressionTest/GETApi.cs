using NUnit.Framework;
using RestSharp;
using System;

using RestSharp.Serialization.Json;
using System.Collections.Generic;
using AventStack.ExtentReports;
using RestSharpPOC.Utility;
using Application;
using System.Configuration;

namespace regressionTest
{
    [TestFixture]
    public class GETApi
    {
     
        [Test]
        public void Test1()
        {
            ReadProperty readProperty = new ReadProperty();
            readProperty.readProp();
       

            ExtentReports obj = Reporter.GetInstance();
            ExtentTest test;

           test = obj.CreateTest("Get Api").Info("Test Case Start for Get Api");
            

            var client = new RestClient(BaseApi.baseUrl);
            var request = new RestRequest(BaseApi.GET_API+"{userId}",Method.GET);
            request.AddUrlSegment("userId", 2);
         
     
            request.OnBeforeDeserialization = response => { response.ContentType = "application/json"; };

          

            IRestResponse response = client.Execute(request);
            string message = (response.StatusCode).ToString();
            Console.WriteLine("Value::"+ response.StatusCode);
            Console.WriteLine("Value::" + response.StatusDescription);

            //print request url
            Console.WriteLine("Response:::" + string.Format(response.ResponseUri.ToString()));

            var deserialize = new JsonDeserializer();
                 var output = deserialize.Deserialize<Dictionary<string, string>>(response);

            Assert.That(message, Is.EqualTo("OK"), "Incorrect Message");
            test.Log(Status.Pass,"Test case passed");
            obj.Flush();

        }
    }
}
