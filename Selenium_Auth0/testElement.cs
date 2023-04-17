using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Auth0
{
    internal class testElement : baseTest
    {
        public override IWebElement FindEmailElement()
        {
            return driver.FindElement(By.CssSelector("input[name='email']"));
        }

        public override IWebElement FindPasswordElement()
        {
            return driver.FindElement(By.CssSelector("input[name='password']"));
        }

        public override IWebElement FindUsernamelElement()
        {
            return driver.FindElement(By.CssSelector("input[name='username']")); 
        }
    }
}
