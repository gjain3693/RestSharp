using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework;

namespace RestSharpPOC.Utility
{

    public class Reporter
    {
       public static ExtentHtmlReporter htmlReporter;
       public static ExtentReports extent;
  

        public static ExtentReports GetInstance()
        {
            if(extent == null)
            {
                string reportPath = @"/Users/gauravjain/Projects/RestSharpPOC/RestSharpPOC/Report/index.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("User", "Nick");
                extent.AddSystemInfo("Env", "POC");
            }

            return extent;
        }
    }
}
