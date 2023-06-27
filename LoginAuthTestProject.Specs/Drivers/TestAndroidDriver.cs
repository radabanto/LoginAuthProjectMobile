using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecRun;

namespace LoginAuthTestProject.Specs.Drivers
{
    public class TestAndroidDriver
    {
        private readonly TestRunContext _testRunContext;
        public AndroidDriver<AndroidElement> Driver { get; private set; }

        public TestAndroidDriver(TestRunContext testRunContext)
        {
            _testRunContext = testRunContext;
        }

        public void StartApp()
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability("appium:automationName", "UIAutomator2");
            driverOptions.AddAdditionalCapability("appium:platformVersion", "13.0");
            var apkPath = Path.Combine(_testRunContext.TestDirectory, "..\\..\\..\\..\\LoginAuthProject.Android\\bin\\x86\\Release\\com.companyname.loginauthproject-Signed.apk");
            driverOptions.AddAdditionalCapability("appium:app", apkPath);

            Driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723"), driverOptions, TimeSpan.FromSeconds(180));
        }

        public void WaitForElement(AndroidElement element, int noOfSeconds = 10)
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(noOfSeconds)).Until(d => element.Displayed);
        }

        public void StopApp()
        {
            Driver.Quit();
        }
    }
}
