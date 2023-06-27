using LoginAuthTestProject.Specs.Drivers;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecRun;

namespace LoginAuthTestProject.Specs.Hooks
{
    [Binding]
    public class BaseHooks
    {
        private readonly TestAndroidDriver _androidDriver;

        public BaseHooks(TestAndroidDriver appiumDriver)
        {
            _androidDriver = appiumDriver;
        }

        [BeforeScenario()]
        public void StartAndroidApp()
        {
            _androidDriver.StartApp();
        }

        [AfterScenario()]
        public void ShutdownAndroidApp()
        {
            _androidDriver.StopApp();
        }
    }
}

