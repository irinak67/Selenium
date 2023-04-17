using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_GallerU_AUTH0
{
    internal class FindElement : BaseClass
    {
        public override IWebElement FindEmailElement()
        {
            return driver.FindElement(By.CssSelector("input[inputmode='email']"));
        }

        public override IWebElement FindSingUpPasswordElement()
        {
            return driver.FindElement(By.CssSelector("input[autocomplete='new-password']"));
        }

        public override IWebElement FindLogInPasswordElement()
        {
            return driver.FindElement(By.CssSelector("input[autocomplete='current-password']"));
        }
    }
}
