using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace PniTraining
{
    public class PageObject : DriverManager
    {
        [FindsBy(How = How.Id, Using = "lst-ib")]
        public IWebElement seachBox;

        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement clickSearchBox;

        public PageObject(IWebDriver webDriver, string url) : base(webDriver, url)
        {
            
        }

        public void enterSearch()
        {
            seachBox.SendKeys(Keys.Enter);
        }

        public void setSearchField(string searchKeyword)
        {
            seachBox.Clear();
            seachBox.SendKeys(searchKeyword);
        }
    }
}
