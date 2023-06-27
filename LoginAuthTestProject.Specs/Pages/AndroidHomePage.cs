using LoginAuthTestProject.Specs.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;

namespace LoginAuthTestProject.Specs.Pages
{
    class AndroidHomePage : AndroidBasePage
    {
        
        public AndroidHomePage(TestAndroidDriver androidDriver) : base(androidDriver)
        {
        }

        public AndroidElement GetLearnMoreButton()
        {
            return _driver.Driver.FindElement(By.ClassName("android.widget.Button"));
        }
    }
}
