using OpenQA.Selenium;

namespace Selenium_GallerU_AUTH0
{
    internal class FindElement : BaseClass
    {
        public override IWebElement FindEmailElement()
        {
            //return driver.FindElement(By.CssSelector("input[inputmode='email']"));
            return ElementFinder.Factory(driver).FinsEmailInput();
        }

        public override IWebElement FindSingUpPasswordElement()
        {
            return ElementFinder.Factory(driver).FindSingUpPasswordInput();
        }

        public override IWebElement FindLogInPasswordElement()
        {
            return ElementFinder.Factory(driver).FindLoginPasswordInput();
        }
    }
}
