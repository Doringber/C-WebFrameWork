using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Test_Frameworks.POM
{
    public class BasicMethods: Base
    {
        public void ClickElement(IWebDriver driver, By element, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until(drv => drv.FindElement(element));
            }
            driver.FindElement(element).Click();
     }
    
     public void sendKeys(IWebDriver driver, By element, string keys)
    {
     driver.FindElement(element).SendKeys(keys);
     }

    public void pressKey(IWebDriver driver,By element, string keys)
    {
        driver.FindElement(element).SendKeys(keys);
    }



    }
}
