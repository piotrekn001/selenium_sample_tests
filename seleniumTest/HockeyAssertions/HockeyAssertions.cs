using NUnit.Framework;
using OpenQA.Selenium;

namespace hockeyTest
{
    public class HockeyAssertions
    {
        public static void AssertElementIsDisplayed(By elementSelector)
        {
            Assert.IsTrue(Helpers.CheckIfElementIsDisplayed(elementSelector));
        }
        public static void HockeyTrainingProgramIsOpened()
        {
            AssertElementIsDisplayed(SpeedTrainingPageElements.SpeedProgramTrainingTitle());
        }
        public static void ChatIsDisplayed()
        {
            AssertElementIsDisplayed(MainPageElements.Chat());
        }
        public static void CommentFormIsDisplayed()
        {
            AssertElementIsDisplayed(SpeedTrainingPageElements.CommentForm());
        }
    }
}
