using OpenQA.Selenium;

namespace SP_Challenge.Pages
{
    public class BasePage
    {
        public IWebDriver driver;

        public BasePage(IWebDriver driver) { this.driver = driver; }

        public string baseURL = "https://www.wikipedia.org/";

        public void goTo (string URL) { driver.Navigate().GoToUrl(URL); }

        public void click (By element) {driver.FindElement(element).Click(); }

        public void writeText (By element, string text) { driver.FindElement(element).SendKeys(text); }

        public string readText (By element) { return driver.FindElement(element).Text; }
    }
}
