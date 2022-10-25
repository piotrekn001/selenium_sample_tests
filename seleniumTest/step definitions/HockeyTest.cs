using System.Configuration;
using TechTalk.SpecFlow;


namespace hockeyTest.step
{

    [Binding]
    public class HockeyTest
    {
        [Given(@"I am on ‘hockeytraining.com’ page")]
        public void GivenILoadUrl()
        {
            Helpers.OpenUrl(ConfigurationManager.AppSettings["hockeyTrainingUrl"]);
        }
        [Then(@"the page title is displayed")]
        public void GivenThePageIsDisplayed()
        {
            HockeyAssertions.AssertElementIsDisplayed(MainPageElements.MainPageTitle());
        }
        [Then(@"I close the newsletter window")]
        public void GivenICloseTheNewsletterWindow()
        {
            try
            {
                Helpers.Click(MainPageElements.NewsletterCloseButton());
            }
            catch
            {

            }
        }
        [When(@"I click the ‘chat icon’")]
        public void WhenIClickChatIcon()
        {
            Helpers.Click(MainPageElements.ChatButton());
        }
        [Then(@"The chat is opened")]
        public void ThenTheChatIsOpened()
        {
            HockeyAssertions.ChatIsDisplayed();
        }

        [When(@"I search for (.*) phrase")]
        public void WhenISearchForSpeedPhrase(string phrase)
        {
            Helpers.Click(MainPageElements.SearchButton());
            Helpers.EnterText(MainPageElements.SearchBar(), phrase, true);
        }
        [Then(@"I can click ‘Get The Hockey Speed Program’ button")]
        public void ThenICanClickGetTheHockeySpeedProgramButton()
        {
            Helpers.Click(MainPageElements.HockeyProgramSearchResult());
        }
        [Then(@"I am redirected to new page")]
        public void ThenIAmRedirectedToNewPageInTheNewTab()
        {
            HockeyAssertions.HockeyTrainingProgramIsOpened();
        }
        [When(@"I click on the comments button")]
        public void WhenIClickOnTheCommentsButton()
        {
            Helpers.Click(SpeedTrainingPageElements.CommentsButton());
        }
        [Then(@"the comment form is displayed")]
        public void ThenTheCommentFormIsDisplayed()
        {
            HockeyAssertions.CommentFormIsDisplayed();
        }
        
        [When(@"I open the same page in a new tab")]
        public void WhenIOpenTheSamePageInANewTab()
        {
            Helpers.OpenUrlInNewTab(ConfigurationManager.AppSettings["hockeyTrainingUrl"]);
        }

    }
}
