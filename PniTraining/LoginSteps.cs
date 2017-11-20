using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace PniTraining
{
    [Binding]
    public class LoginSteps
    {
        private PageObject seachPage;
        private IWebDriver driver;

        [BeforeScenario()]
        public void Setup()
        {
            driver = new ChromeDriver();
            
        }

        [AfterScenario()]
        public void TearDown()
        {
            driver.Quit();
        }

        [Given(@"I am at the search page")]
        public void GivenIAmAtTheSearchPage()
        {
            seachPage = new PageObject(driver, "https://www.google.com/");
        }
        
        [When(@"I use the keyword (.*)")]
        public void WhenIUseTheKeyword(string keyword)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be at the results page")]
        public void ThenIShouldBeAtTheResultsPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
