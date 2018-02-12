
using OpenQA.Selenium;

namespace Pages
{
    public class SearchResults : BasePage
    {
        public SearchResults(IWebDriver driver) : base(driver)
        {
        }

        private By results = By.PartialLinkText("MSTest Unit Testing Tutorial for beginners");

        public void OpenResults() 
        {
            ClickOn(results);
        }

        public string ResultsTitle() {
            return PageTitle();
        }
    }
}