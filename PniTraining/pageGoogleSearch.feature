Feature: Login
  In order to access my account
  As a user of the website
  I want to log into the website

@scenarioSearchByKeyword
Scenario: Logging in with valid credentials
  Given I am at the search page
  When I use the keyword testing
  And I click the search button
  Then I should be at the results page
