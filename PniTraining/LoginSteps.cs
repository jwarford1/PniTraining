using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace PniTraining
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I am at the login page")]
        public void GivenIAmAtTheLoginPage()
        {
            ScenarioContext.Current.Pending();
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
