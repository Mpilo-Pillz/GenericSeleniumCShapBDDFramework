using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1
{
    [Binding]
    public class Send_Keys_Step_Definitions
    {
        [When(@"I enter '(.*)' on the '(.*)' element")]
        public void WhenIEnterOnTheElement(string userInput, string elementID)
        {
            Steps.Driver_Step_Definitions.driver.FindElementById(elementID).SendKeys(userInput);
        }
    }
}
