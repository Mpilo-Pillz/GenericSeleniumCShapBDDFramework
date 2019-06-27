using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Enums;

namespace ClassLibrary1.Steps
{
    [Binding]
    public class Driver_Step_Definitions
    {
        public static ChromeDriver driver;
        public static AppiumDriver<AndroidElement> mobileDriver;
        public static String localDirectory;

        public void TestOnAndroid()
        {
            DesiredCapabilities cap = new DesiredCapabilities();

            cap.SetCapability("unicodeKeyboard", false);
            cap.SetCapability("resetKeyBoard", false);
            cap.SetCapability("deviceName", "adbdeviceattaced");
            cap.SetCapability("platformName", "Android");
            cap.SetCapability(MobileCapabilityType.BrowserName, "Chrome");
            mobileDriver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
        }

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
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //driver.Url = mpiloUrl;
            driver.Navigate().GoToUrl(mpiloUrl);

            Actions actionObject = new Actions(driver);
            driver.Manage().Cookies.DeleteAllCookies();
            actionObject.KeyDown(Keys.Control).SendKeys(Keys.F5).KeyUp(Keys.Control).Perform();
            DocReady();
            
        }

        public static void DocReady()
        {
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            //wait.Until((x) =>
            //{
            //    return ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete");
            //});
            //Thread.Sleep(2000);
        }

        [When(@"I take a screenshot '(.*)' and store it on '(.*)'")]
        public void WhenITakeAScreenshotAndStoreItOn(string picName, string userFolder)
        {
            localDirectory = "C:\\Users\\" + userFolder + "\\Pictures\\" + picName + ".jpg";
            ITakesScreenshot captureScreenShot = (ITakesScreenshot)driver;
            Screenshot screenshot = captureScreenShot.GetScreenshot();
            screenshot.SaveAsFile(localDirectory);
        }




    }
}
