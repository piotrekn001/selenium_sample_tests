using OpenQA.Selenium;


namespace hockeyTest
{
    public class SpeedTrainingPageElements
    {
        public static By SpeedProgramTrainingTitle()
        {
            string selector = "#primary > div.cs-entry__header.cs-entry__header-standard.cs-video-wrap > div > div > h1 > span";
            By speedProgramTitle = Helpers.ByCss(selector);

            return speedProgramTitle;
        }
        public static By CommentsButton()
        {
            string selector = "#comments > button";
            By commentsButton = Helpers.ByCss(selector);

            return commentsButton;
        }
        public static By CommentForm()
        {
            string selector = "#comment";
            By commentForm = Helpers.ByCss(selector);

            return commentForm;
        }
    }
}
