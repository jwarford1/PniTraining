using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PniTraining
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver initialDriver;
        private PageObject searchPage;
        

        [BeforeScenario()]
        public void Setup()
        {
            
            initialDriver = new ChromeDriver();
            
        }

        [AfterScenario()]
        public void TearDown()
        {
           initialDriver.Quit();
        }

        [Given(@"I am at the login page")]
        public void GivenIAmAtTheLoginPage()
        {
            searchPage = PageObject.NavigateTo(initialDriver, "https://www.google.com/");
        }
        
        [When(@"I fill in the following form")]
        public void WhenIFillInTheFollowingForm(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be at the home page")]
        public void ThenIShouldBeAtTheHomePage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
