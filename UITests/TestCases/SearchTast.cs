using System;
using Utils;
using NUnit.Framework;
using Pages;

namespace TestCases
{
    public class SearchTest : BaseTest
    {
        HomePage homePage;
        SearchResults results;

        const String URL = "https://google.com";
        const String EXPECTED = "MSTest Unit Testing Tutorial for beginners : C# Unit Testing | Udemy";

        [Test]
        public void TestSearch()
        {
            homePage = new HomePage(driver);
            homePage.OpenHomePage(URL);
            homePage.SearchForText("Testing with C#");

            results = new SearchResults(driver);
            results.OpenResults();
            Assert.IsTrue(results.ResultsTitle().Contains(EXPECTED));

        }

    }
}