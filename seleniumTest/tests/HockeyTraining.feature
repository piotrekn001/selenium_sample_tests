Feature: HockeyTraining

Scenario: successfully select first result of a speed phrase search in chat window
Given I am on ‘hockeytraining.com’ page
Then the page title is displayed
Then I close the newsletter window
When I click the ‘chat icon’
Then The chat is opened
When I search for speed phrase
Then I can click ‘Get The Hockey Speed Program’ button
When I click on the comments button
Then the comment form is displayed
When I open the same page in a new tab
Then the page title is displayed