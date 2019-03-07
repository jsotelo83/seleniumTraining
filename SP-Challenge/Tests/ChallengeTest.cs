using NUnit.Framework;
using SP_Challenge.Pages;

namespace SP_Challenge.Tests
{
    class ChallengeTest : BaseTest
    {

        [Test]

        public void navigateToHomeTest ()
        {
            HomePage homePage = new HomePage(driver);

            homePage.goToHome();

            homePage.validateCurrentURL(homePage.getBaseURL());
        }

        [Test]

        public void validateSearch()
        {
            HomePage homePage = new HomePage(driver);
            ArticlePage articlePage = new ArticlePage(driver);

            string searchString = "Taylor Swift";

            homePage.goToHome();
            homePage.search(searchString);

            articlePage.validateExpectedArticle(searchString);

        }

        [Test]

        public void validatesStudioAlbums()
        {

        HomePage homePage = new HomePage(driver);
        ArticlePage articlePage = new ArticlePage(driver);

        string[] albums;
        albums = new string[6];

        albums[0] = "Taylor Swift";
        albums[1] = "Fearless";
        albums[2] = "Speak Now";
        albums[3] = "Red";
        albums[4] = "1989";
        albums[5] = "Reputation";

        string searchString = "Taylor Swift";

        homePage.goToHome();
        homePage.search(searchString);

        articlePage.validateExpectedStudioAlbums(albums);

        }

        [Test]

        public void validatesStudioAlbumHoverMessage()
        {
        HomePage homePage = new HomePage(driver);
        ArticlePage articlePage = new ArticlePage(driver);

        string searchString = "Taylor Swift";

        homePage.goToHome();
        homePage.search(searchString);

        articlePage.validateHoverMessageAppears();

        }

    }

}
