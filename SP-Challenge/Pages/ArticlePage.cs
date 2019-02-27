using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace SP_Challenge.Pages
{
    public class ArticlePage:BasePage
    {
        public ArticlePage(IWebDriver driver) : base(driver) { }

        By articleTitle = By.CssSelector("#firstHeading");
        By studioAlbumsRow = By.XPath("//th[@scope='row' and @class='navbox-group' and contains(text(),'Studio albums')]");
        By reputationStudioAlbumLink = By.XPath("(//td[@class='navbox-list navbox-odd']//child::div//child::ul//child::li//child::a[text()='Reputation'])[1]");
        By popUp = By.CssSelector(".mwe-popups");

        public String getPageTitle(){ return driver.Title;}

        public string getArticleTitle()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            var element = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = driver.FindElement(articleTitle);
                    return elementToBeDisplayed.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            IWebElement element1 = driver.FindElement(articleTitle);
            return element1.Text;
        }

        public void validateExpectedArticle(String articleName)
        {
            string actualPageTitle = this.getPageTitle();
            string actualArticleTitle = this.getArticleTitle();

            Assert.True(actualPageTitle.Contains(articleName), "The page title is different than expected");
            Assert.True(actualArticleTitle.Contains(articleName), "The article title is different than expected");
        }

        public void validateExpectedStudioAlbums(string[] albums)
        {
            string albumsString = readText(studioAlbumsRow);
            Console.Write(albumsString);
            bool flag = true;
            foreach (string album in albums)
            {
                if (albumsString.Contains(album) == false)
                {
                    flag = false;
                }
            }

            Assert.True(flag, "The albums don't match");
        }

        public void validateHoverMessageAppears()
        {
            IWebElement link = driver.FindElement(reputationStudioAlbumLink);

            click(studioAlbumsRow);
            //Actions action = new Actions(driver);
            //action.MoveToElement(link).Perform();

            string javaScript = "var evObj = document.createEvent('MouseEvents');" +
                "evObj.initMouseEvent(\"mouseover\",true, false, window, 0, 0, 0, 0, 0, false, false, false, false, 0, null);" +
                "arguments[0].dispatchEvent(evObj);";
            IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
            //Thread.Sleep(2000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            
            js.ExecuteScript(javaScript, link);
            
            var element = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = driver.FindElement(popUp);
                    return elementToBeDisplayed.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            IWebElement element1 = driver.FindElement(popUp);
            Assert.True(element1.Displayed);
        }


    }
}
