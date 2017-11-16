using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PniTraining
{
    public class PageObject
    {
        [FindsBy(How = How.Id, Using = "lst-ib")]
        public IWebElement seachBox;

        private static  IWebDriver driver;

        public static PageObject  NavigateTo(IWebDriver webDriver, string url)
        {
            driver = webDriver;
            driver.Navigate().GoToUrl(url);
            var searchPage = new PageObject();
            PageFactory.InitElements(driver, searchPage);
            return searchPage;
        }
        public void setSearchField(string searchKeyword)
        {
            seachBox.Clear();
            seachBox.SendKeys(searchKeyword);
        }
    }
}
