using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UnitTestProject1.Features
{
    [Binding]
    class Login 
    {
        private IWebDriver _driver;

        public Login(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _driver.Navigate().GoToUrl("https://www.google.com");
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            Console.WriteLine(" Step2");
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            Console.WriteLine(" Step3");
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            Console.WriteLine(" Step4");
        }

    }
}
