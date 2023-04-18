using OpenQA.Selenium;
using System.Xml.Linq;

namespace Selenium_GallerU_AUTH0
{
    internal class ElementFinder
    {
        protected IWebDriver driver;
        public ElementFinder(IWebDriver d)
        {
            driver = d;
        }
        public IWebElement FindLoginButton()
        {
            return driver.FindElement(By.CssSelector("button[class='button-0-2-2']"));
        }

        public IWebElement FindSingUpButton()
        {
            return driver.FindElement(By.CssSelector("a[class='cddfc848a ca43aaebf']"));                                                                
        }

        public IWebElement FindSubmitButton()
        {
            return driver.FindElement(By.Name("action"));
        }

        public IWebElement FinsEmailInput()
        {
            return driver.FindElement(By.CssSelector("input[inputmode='email']"));
        }

        public IWebElement FindSingUpPasswordInput()
        {
            return driver.FindElement(By.CssSelector("input[autocomplete='new-password']"));
        }

        public IWebElement FindLoginPasswordInput()
        {
            return driver.FindElement(By.CssSelector("input[autocomplete='current-password']"));
        }

        public IWebElement FindAlertWrongEmail()
        {
            return driver.FindElement(By.CssSelector("span[id='error-element-email']"));
        }
        public static ElementFinder Factory(IWebDriver d)
        {
            return new ElementFinder(d);
        }
    }
}
