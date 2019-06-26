using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1.Steps
{
    [Binding]
    public class Driver_Step_Definitions
    {
        public static ChromeDriver driver;
        public static String localDirectory;

        public static IWebDriver Driver { get; set; }

        [BeforeTestRun]
        public static void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);
            driver.Manage().Cookies.DeleteAllCookies();
        }

        public static ChromeDriver GetChromeDriverInstance
        {
            get { return driver;  }
        }

        [Given(@"I go to the url '(.*)'")]
        public void GivenIGoToTheUrl(string mpiloUrl)
        {
            
            driver.Navigate().GoToUrl(mpiloUrl);
            driver.Url = mpiloUrl;
        }

    }
}
