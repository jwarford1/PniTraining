using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PniTraining
{
    public  class DriverManager
    {
        private IWebDriver driver;

        public DriverManager(IWebDriver webDriver, string url)
        {
            driver = webDriver;
            driver.Navigate().GoToUrl(url);
            //var searchPage = new DriverManager();
            PageFactory.InitElements(driver, this);
            
        }

        public string getTitle()
        {
            return driver.Title;
        }
    }
}
