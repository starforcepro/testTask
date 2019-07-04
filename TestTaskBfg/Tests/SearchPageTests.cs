using NUnit.Framework;
using TestTaskBfg.Core;
using TestTaskBfg.Pages;

namespace TestTaskBfg.Tests
{
    [TestFixture]
    public class SearchPageTests : SeleniumTestBase
    {
        [Test]
        public void SearchIsWorked()
        {
            DriverPool.Get().Navigate().GoToUrl(testServer);

            var searchPage = new SearchPage();
            var resultsPage = new SearchResultsPage();

            searchPage
                .SelectSearchResultsDropList(25)
                .FillSearchTextbox("test")
                .ClickSearchButton();

            Assert.IsTrue(resultsPage.ResultsTableIsDisplayed());
        }
    }
}
