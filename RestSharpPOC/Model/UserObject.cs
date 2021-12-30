using System;
using Newtonsoft.Json.Linq;

namespace RestSharpPOC.Model
{
    public class UserObject
    {
        public JObject setUserObject()
        {
            JObject jobject = new JObject();
            jobject.Add("name", "Honey");
            jobject.Add("job", "CA");

            return jobject;
        }
    }
}
