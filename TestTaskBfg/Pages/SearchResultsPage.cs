using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestTaskBfg.Pages
{
    public class SearchResultsPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/center/div/div/div/p/a/button")]
        private IWebElement returnButton;
        [FindsBy(How = How.XPath, Using = "/html/body/center/div/div/div/center/table/tbody")]
        private IWebElement resultsTable;

        public SearchResultsPage ClickReturnButton()
        {
            returnButton.Click();

            return InitPage(this);
        }

        public bool ResultsTableIsDisplayed()
        {
            return resultsTable.Displayed;
        }
    }
}
