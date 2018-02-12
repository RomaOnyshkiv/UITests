using System;
using OpenQA.Selenium;

namespace Pages
{
    public class BasePage
    {
        private IWebDriver driver;

        public BasePage(IWebDriver driver) {
            this.driver = driver;
        }

        protected void ClickOn(By by) {
            driver.FindElement(by).Click();
        }

        protected void PressEnter(By by)
        {
            driver.FindElement(by).SendKeys(Keys.Return);
        }

        protected void TypeText(By by, String text) {
            driver.FindElement(by).SendKeys(text);
        }

        protected String PageTitle() {
            return driver.Title;
        }

        protected void OpenURL(String url) {
            driver.Url = url;
        }
    }
    
}

