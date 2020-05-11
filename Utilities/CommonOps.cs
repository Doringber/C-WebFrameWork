using System;
using NUnit.Framework;

namespace Test_Frameworks.Utilities
{
    public class CommonOps : Browsers
    {
        [SetUp]
        public void Setup()
        {
            Browsers browsers = new Browsers();
            browsers.jsonFile();
            Console.WriteLine(Browsers.browser.ToString());
            Console.WriteLine(Browsers.url.ToString());


            Init(Browser.Chrome, Browsers.url.ToString());
            Console.WriteLine("Test Run");


        }

        [TearDown]
        public void tearDown()
        {
            Console.WriteLine("Test Finish");
            WebDriver.Quit();

        }
    }
}
