using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Utils 
{
    public class BaseTest 
    {
        public static IWebDriver driver;

        [SetUp]
        public void init() {
            if (driver == null) {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }
        }

        [TearDown]
        public void tearDown() {
            if (driver != null) {
                driver.Quit();
            }
        }
    }    
}