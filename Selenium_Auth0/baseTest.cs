using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Selenium_Auth0
{
    internal abstract class baseTest
    {
        protected IWebDriver driver;

        public void Pause(int mili = 3000)
        {
            System.Threading.Thread.Sleep(mili);
        }
        public void Start()
        {
            string url = "https://ashy-grass-05ad28c10.3.azurestaticapps.net";
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            Pause();

            IWebElement loginBtn = driver.FindElement(By.CssSelector("button[class='btn btn-primary w-100']"));
            if (loginBtn != null)
            {
                loginBtn.Click();
                Pause();
            }
            else Console.WriteLine("Login Button wasn't available");
        }

        public void SingUp()
        {
            IWebElement signUpBtn = driver.FindElement(By.CssSelector("a[class='c8d123439 ce1bebd2d']"));
            if (signUpBtn != null)
            {
                try
                {
                    signUpBtn.Click();
                    Console.WriteLine("SignUp Button was clicked");
                    Pause();
                }
                catch
                {
                    Console.WriteLine("SignUp Button wasn't clicked");
                }
            }
            else Console.WriteLine("SignUp Button wasn't available");
        }

        public void Finish()
        {
            if (driver != null) driver.Close();
        }

        public void AlertOfError(IWebDriver element)
        {
            if (element.FindElements(By.CssSelector("div[id='prompt-alert']")).Count != 0) Console.WriteLine("Something went wrong, please try again later");
            else if (element.FindElements(By.CssSelector("span[id='error-element-email']")).Count != 0) Console.WriteLine("Email is not valid");
            else if (element.FindElements(By.CssSelector("div[class='cb7ca42d5']")).Count != 0) Console.WriteLine("Password is not valid");
            else if (element.FindElements(By.CssSelector("span[id='error-element-password']")).Count != 0) Console.WriteLine("Wrong email or password");
        }

        public void RunSingUp(string email, string password)
        {
            Start();

            SingUp();

            IWebElement nameInput = FindEmailElement();
            if (nameInput != null)
            {
                try
                {
                    nameInput.SendKeys(email);
                    Console.WriteLine($"Username was sent: {email}");
                }
                catch
                {
                    Console.WriteLine("Wrong email");
                }
            }
            else Console.WriteLine("Element input-email wasn't available");

            IWebElement passwordInput = FindPasswordElement();
            if (passwordInput != null)
            {
                try
                {
                    passwordInput.SendKeys(password);
                    Console.WriteLine($"Password was sent = {password}");
                }
                catch
                {
                    Console.WriteLine("uncorrect Password");
                }
            }
            else Console.WriteLine("Element input-password wasn't available");

            IWebElement submitBtn = driver.FindElement(By.CssSelector("button[type='submit']"));
            if (submitBtn != null)
            {
                try
                {
                    submitBtn.Click();
                    Console.WriteLine("Create Account Button was clicked");
                    Pause();
                }
                catch
                {
                    Console.WriteLine("Create Account Button wasn't clicked");
                }

                AlertOfError(driver);

                Finish();
            }
            else Console.WriteLine("Submit Button wasn't available");
        }

        public void RunLogIn(string username, string password)
        {
            Start();

            IWebElement nameInput = FindUsernamelElement();
            if (nameInput != null)
            {
                try
                {
                    nameInput.SendKeys(username);
                    Console.WriteLine($"Username was sent: {username}");
                }
                catch
                {
                    Console.WriteLine("Username wasn't sent");
                }
            }
            else Console.WriteLine("Element input-email wasn't available");

            IWebElement passwordInput = FindPasswordElement();
            if (passwordInput != null)
            {
                try
                {
                    passwordInput.SendKeys(password);
                    Console.WriteLine($"Password was sent = {password}");
                }
                catch
                {
                    Console.WriteLine("Password wasn't sent");
                }
            }
            else Console.WriteLine("Element input-password wasn't available");

            IWebElement submitBtn = driver.FindElement(By.CssSelector("button[type='submit']"));
            if (submitBtn != null)
            {
                try
                {
                    submitBtn.Click();
                    Console.WriteLine("Create Account Button was clicked");
                    Pause();
                }
                catch
                {
                    Console.WriteLine("Create Account Button wasn't clicked");
                }

                AlertOfError(driver);

                Finish();
            }
            else Console.WriteLine("Submit Button wasn't available");
        }
        public abstract IWebElement FindEmailElement();

        public abstract IWebElement FindUsernamelElement();

        public abstract IWebElement FindPasswordElement();
    }

}
