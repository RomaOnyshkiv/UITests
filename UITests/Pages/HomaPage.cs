using System;
using OpenQA.Selenium;

namespace Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        private By searchField = By.Name("q");
        private By searchBtn = By.Name("btnK");

        public void OpenHomePage(String url) {
            OpenURL(url);
        }

        public void SearchForText(String text) {
            TypeText(searchField, text);
            PressEnter(searchField);
        }
    }
}