using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    [Binding]
    public sealed class Hooks
    {
        private  IObjectContainer _objectContainer;
        private  IWebDriver _driver;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }
        [BeforeTestRun]
        
        public  void BeforeFeature()
        {
            _driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);

        }

        [AfterTestRun]
        public  void AfterFeature()
        {
            
           
            // thread.Name = "My Thread";
        }
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
           
            Thread thread = Thread.CurrentThread;
            Console.WriteLine("Thread Name = {0}", thread.Name);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Close();
        }
    }
}
