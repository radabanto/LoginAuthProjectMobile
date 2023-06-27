using LoginAuthTestProject.Specs.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAuthTestProject.Specs.Pages
{
    class AndroidLoginPage : AndroidBasePage
    {
        public AndroidLoginPage(TestAndroidDriver androidDriver) : base(androidDriver)
        {
            
        }

        public AndroidElement GetLoginButton()
        {
            _driver.WaitForElement(_driver.Driver.FindElement(By.ClassName("android.widget.Button")));
            return _driver.Driver.FindElement(By.ClassName("android.widget.Button"));
        }

        public void ClickLogin()
        {
            _driver.WaitForElement(_driver.Driver.FindElement(By.ClassName("android.widget.Button")));
            _driver.Driver.FindElement(By.ClassName("android.widget.Button")).Click();
        }
    }
}
