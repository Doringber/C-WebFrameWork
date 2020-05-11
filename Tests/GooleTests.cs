using System;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Test_Frameworks.POM;
using Test_Frameworks.Utilities;

namespace Test_Frameworks
{
    [TestFixture]
    public class Tests : CommonOps
    {
        //public string homeURL;


        //[SetUp]
        //public void Setup()
        //{
        //    Browsers browsers = new Browsers();
        //    browsers.jsonFile();
        //    Console.WriteLine(Browsers.browser.ToString());
        //    Console.WriteLine(Browsers.url.ToString());
            

        //    Init(Browser.Chrome, Browsers.url.ToString());
        //    Console.WriteLine("Test Run");


        //}


        [Test]
        public void TestSearchText()
        {
            WorkFlow workflow = new WorkFlow();
            workflow.HomeScreenSearch(WebDriver, "dor ingber");
     
            var url = WebDriver.Url;
            Assert.IsTrue(url.Contains("dor"));

        }

        [Test]
        public void TestMoreLuck()
        {
            WorkFlow workflow = new WorkFlow();
            workflow.HomeScreenMoreLuck(WebDriver);

            var url = WebDriver.Url;
            Assert.IsTrue(url.Contains("doodles"));

        }

        //[TearDown]
        //public void tearDown()
        //{
        //    Console.WriteLine("Test Finish");
        //    WebDriver.Quit();

        //}
    }
}