using System;
using System.Configuration;
namespace Application
{
    public class ReadProperty
    {
        public void readProp()
        {
            string str = ConfigurationManager.AppSettings["name"];
            Console.WriteLine("str:::" + str);
        }
    }
}
