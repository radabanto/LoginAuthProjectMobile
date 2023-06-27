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
    class AndroidBasePage
    {
        protected TestAndroidDriver _driver;
        protected AndroidElement hamburgerMenuElement;

        public AndroidBasePage(TestAndroidDriver androidDriver)
        {
            _driver = androidDriver;
        }

        public AndroidElement GetHamburgerMenuButton()
        {
            return _driver.Driver.FindElementByAccessibilityId("OK");
        }

        public void ClickHamburgerMenuButton()
        {
            _driver.Driver.FindElementByAccessibilityId("OK").Click();
        }

        public void ClickLogoutWithinHamburgerFlyout()
        {
            _driver.Driver.FindElement(By.XPath("//android.widget.LinearLayout[@content-desc=\"Logout\"]/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView")).Click();
        }
    }
}
