using NUnit.Framework;
using TestTaskBfg.Pages;
using TestTaskBfg.Core;

namespace TestTaskBfg.Tests
{
    [TestFixture]
    class SearchResultsPageTests : SeleniumTestBase
    {
        [Test]
        public void ReturnButtonIsWorked()
        {
            DriverPool.Get().Navigate().GoToUrl(testServer + "?page_number=25&intitle=test&page=1");

            var searchPage = new SearchPage();
            var resultsPage = new SearchResultsPage();

            resultsPage.ClickReturnButton();

            Assert.IsTrue(searchPage.StackOverSearchTextIsDisplayed());
        }
    }
}
