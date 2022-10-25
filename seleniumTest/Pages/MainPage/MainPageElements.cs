using OpenQA.Selenium;

namespace hockeyTest
{
    public class MainPageElements
    {
        public static By MainPageTitle()
        {
            string selector = "#primary > div.cs-entry__header.cs-entry__header-standard > div > div > h1 > span";
            By mainPageTitle = Helpers.ByCss(selector);

            return mainPageTitle;
        }
        public static By NewsletterCloseButton()
        {
            string selector = "#om-fkuxipz2cb3uu9lephfh-yesno>div>button";
            By newsletterCloseButton = Helpers.ByCss(selector);

            return newsletterCloseButton;
        }
        public static By ChatButton()
        {
            string selector = "body > div.intercom-lightweight-app > div > div.intercom-lightweight-app-launcher-icon.intercom-lightweight-app-launcher-icon-open";
            By chatButton = Helpers.ByCss(selector);

            return chatButton;
        }
        public static By Chat()
        {
            string selector = "#intercom-container > div > div > div";
            By chat = Helpers.ByCss(selector);

            return chat;
        }
        public static By SearchButton()
        {
            string selector = "#page > div > header > div.cs-container > div.cs-header__inner.cs-header__inner-desktop > div.cs-header__col.cs-col-right > span.cs-header__search-toggle>i";
            By searchButton = Helpers.ByCss(selector);

            return searchButton;
        }
        public static By SearchBar()
        {
            string selector = "#page > div > header > div.cs-search > div > form > div > input";
            By searchBar = Helpers.ByCss(selector);

            return searchBar;
        }
        public static By SearchResult()
        {
            string selector = "#primary > div.cs-page__header > h1";
            By searchQuery = Helpers.ByCss(selector);

            return searchQuery;
        }
        public static By HockeyProgramSearchResult()
        {
            string selector = "#primary > div.cs-posts-area.cs-posts-area-posts > div.cs-posts-area__outer.cs-posts-area__type-default > div > article.cs-entry-default.post-11771.post.type-post.status-publish.format-standard.has-post-thumbnail.category-training.cs-entry.cs-video-wrap > div > div.cs-entry__inner.cs-entry__content > h2 > a";
            By hockeyProgram = Helpers.ByCss(selector);

            return hockeyProgram;
        }
        
    }
}
