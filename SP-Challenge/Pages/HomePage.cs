using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SP_Challenge.Pages
{
    public class HomePage:BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        By searchInput = By.Id("searchInput");

        By searchButton = By.XPath("//button[@type='submit']");

        public string getBaseURL () { return baseURL; }

        public void goToHome () { goTo(baseURL); }

        public void search(String searchString)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            var element = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = driver.FindElement(searchInput);
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

            IWebElement element1 = driver.FindElement(searchInput);
            element1.SendKeys(searchString);
            click(searchButton);
        }

        public void validateCurrentURL(String URL){Assert.AreEqual(driver.Url, URL); }

    }
}

