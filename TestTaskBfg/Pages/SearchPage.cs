using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace TestTaskBfg.Pages
{
    class SearchPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/center/div/div/div/p/a/button")]
        private IWebElement getAllRequestsButton;
        [FindsBy(How = How.XPath, Using = @"//*[@id=""page_number""]")]
        private IWebElement resultsNumberDropList;
        [FindsBy(How = How.XPath, Using = @"//*[@id=""intitle""]")]
        private IWebElement searchTextbox;
        [FindsBy(How = How.XPath, Using = "/html/body/center/div/div/div/center/form/div/div[3]/input")]
        private IWebElement searchButton;
        [FindsBy(How = How.XPath, Using = "/html/body/center/div/div/div/strong/h4")]
        private IWebElement stackOverSearchText;

        public SearchPage ClickGetAllRequestsButton()
        {
            getAllRequestsButton.Click();

            return InitPage(this);
        }

        public SearchPage SelectSearchResultsDropList(int resultsNumber)
        {
            var selectElement = new SelectElement(resultsNumberDropList);
            selectElement.SelectByText(resultsNumber.ToString());

            return InitPage(this);
        }

        public SearchPage FillSearchTextbox(string text)
        {
            searchTextbox.SendKeys(text);

            return InitPage(this);
        }

        public SearchPage ClickSearchButton()
        {
            searchButton.Click();

            return InitPage(this);
        }

        public bool StackOverSearchTextIsDisplayed()
        {
            return stackOverSearchText.Displayed;
        }
    }
}
