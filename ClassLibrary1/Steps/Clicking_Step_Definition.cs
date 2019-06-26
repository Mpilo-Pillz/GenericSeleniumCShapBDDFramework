using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1.Steps
{
    [Binding]
    public class Clicking_Step_Definition
    {
        [When(@"I click on the '(.*)' element")]
        public void WhenIClickOnTheElement(string elementByName)
        {
            Steps.Driver_Step_Definitions.driver.FindElementByName(elementByName).Click();
        }
    }
}
