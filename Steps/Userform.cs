using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UnitTestProject1.Steps
{
    [Binding]
    class Userform
    {
        private IWebDriver _driver;

        public Userform(IWebDriver driver)
        {
            _driver = driver;
        }
        [Given(@"I verify the entered user form details in the application database")]
        public void GivenIVerifyTheEnteredUserFormDetailsInTheApplicationDatabase(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I start entering user form details like")]
        public void GivenIStartEnteringUserFormDetailsLike(Table table)
        {
            _driver.Navigate().GoToUrl("http://learn-automation.com/selenium-webdriver-c-sharp-tutorial/");
        }

        [Given(@"I click submit button")]
        public void GivenIClickSubmitButton()
        {
            Console.WriteLine("UF Step2");
        }

        [Then(@"I verify the entered user form details in the application database")]
        public void ThenIVerifyTheEnteredUserFormDetailsInTheApplicationDatabase(Table table)
        {
            Console.WriteLine("UF Step3");
        }

        [Then(@"I logout of application")]
        public void ThenILogoutOfApplication()
        {
            Console.WriteLine("UF Step4");
        }
    }
}
