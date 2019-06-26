using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;

namespace ClassLibrary1.Steps
{
    [Binding]
    public class Asserts_Step_Definitions
    {
        [Then(@"I should see that the element '(.*)' is displayed")]
        public void ThenIShouldSeeThatTheElementIsDisplayed(string elementXpath)
        {
            string path = string.Format("//button[contains(text(), '{0}')]", elementXpath);
            Boolean displayedStatus = Driver_Step_Definitions.driver.FindElement(By.XPath(path)).Displayed;
            Assert.IsTrue(displayedStatus);
        }
    }
}
