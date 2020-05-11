using System;
using OpenQA.Selenium;
using Test_Frameworks.PageObject;

namespace Test_Frameworks.POM
{
    public class WorkFlow
    {
        BasicMethods basicMethod = new BasicMethods();

        public void HomeScreenSearch(IWebDriver driver, String search)
        {
           basicMethod.sendKeys(driver, HomePage.searchInput, search);
           basicMethod.pressKey(driver, HomePage.searchInput, Keys.Enter);
      
        }

        public void HomeScreenMoreLuck(IWebDriver driver)
        {
            basicMethod.ClickElement(driver, HomePage.moreLuckThenBrainbtn, 6);

        }


    }
}
