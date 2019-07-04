using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestTaskBfg.Core;

namespace TestTaskBfg.Pages
{
    public class BasePage
    {
        private IWebDriver driver;

        public BasePage()
        {
            driver = DriverPool.Get();

            InitPage(this);
        }

        public virtual T InitPage<T>(T page) where T : BasePage
        {
            var locker = new object();

            lock (locker)
            {
                PageFactory.InitElements(driver, page);
            }

            return page;
        }
    }
}

