using LoginAuthTestSample.Specs.Drivers;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace LoginAuthTestSample.Specs.Hooks
{
    [Binding]
    public class BaseHooks
    {
        private readonly AppiumDriver _appiumDriver;

        public BaseHooks(AppiumDriver appiumDriver)
        {
            _appiumDriver = appiumDriver;
        }

        [BeforeScenario()]
        public void StartAndroidApp()
        {
            _appiumDriver.StartApp();
        }

        [AfterScenario()]
        public void ShutdownAndroidApp()
        {
            _appiumDriver.StopApp();
        }
    }
}
}