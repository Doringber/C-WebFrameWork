using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using Test_Frameworks.POM;

namespace Test_Frameworks
{
    public class Browsers: Base
    {
        public enum Browser
        {
            Chrome,
            FireFox,
            Safari,
            IE

        }
        static IWebDriver webDriver;
        public static string browser;
        public static string url;

        public static IWebDriver WebDriver { get => webDriver; set => webDriver = value; }




        public void jsonFile()
        {
            var config = new ConfigurationBuilder()
            .AddJsonFile("/Users/doringber/Projects/TC/Test_Frameworks/my-config.json")
            .Build();
            browser = config["browser"];
            //Console.WriteLine(browser);

            url = config["url"];
            //Console.WriteLine(url);
        }
        public static void Init(Browser browser, string url)
        {

            switch (browser)
            {
                case Browser.Chrome:
                    WebDriver = new ChromeDriver();
                    break;
                case Browser.IE:
                    WebDriver = new InternetExplorerDriver();
                    break;
                case Browser.FireFox:
                    WebDriver = new FirefoxDriver();
                    break;
                case Browser.Safari:
                    WebDriver = new SafariDriver();
                    break;
                default:
                    break;
            }
            WebDriver.Manage().Window.Maximize();
            Goto(url);
        }
        public static string Title
        {
            get { return WebDriver.Title; }
        }
        public static IWebDriver getDriver
        {
            get { return WebDriver; }
        }
     
        public static void Goto(string url)
        {
            WebDriver.Url = url;
        }
        public static void Close()
        {
            WebDriver.Quit();
        }

        public static void SwitchTo()
        {
            WebDriver.SwitchTo();
        }

        public static void Navigate()
        {
            WebDriver.Navigate();
        }


    }

}
    

