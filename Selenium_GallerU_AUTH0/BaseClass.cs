using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Selenium_GallerU_AUTH0
{
    internal abstract class BaseClass
    {
        protected IWebDriver driver;

        public void Pause(int mili = 1500)
        {
            System.Threading.Thread.Sleep(mili);
        }
        public void Start()
        {
            string url = "https://blue-field-01c0eaf03.3.azurestaticapps.net";
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            Pause();

            IWebElement loginBtn = driver.FindElement(By.CssSelector("button[class='button-0-2-2']"));
            if (loginBtn != null)
            {
                loginBtn.Click();
                Console.WriteLine("Login Button was available");
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

        public void SubmitSingUpClick()
        {
            IWebElement submitBtn = driver.FindElement(By.Name("action"));
            if (submitBtn != null)
            {
                try
                {
                    submitBtn.Click();
                    Console.WriteLine("Create Account Button was clicked");
                    Pause(5000);
                }
                catch
                {
                    Console.WriteLine("Create Account Button wasn't clicked");
                }

                AlertOfError(driver);
            }
            else Console.WriteLine("Submit Button wasn't available");
        }

        public void SubmitLoginClick()
        {
            IWebElement submitBtn = driver.FindElement(By.Name("action"));
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
            }
            else Console.WriteLine("Submit Button wasn't available");
        }

        public void AlertOfError(IWebDriver element)
        {
            if (element.FindElements(By.CssSelector("div[id='prompt-alert']")).Count != 0)
            {
                Console.WriteLine("Something went wrong, please try again later");
            }
            else if (element.FindElements(By.CssSelector("span[id='error-element-email']")).Count != 0)
            {
                Console.WriteLine("Email is not valid");
            }
            else if (element.FindElements(By.CssSelector("span[class='c184427d0']")).Count != 0)
            {
                Console.WriteLine("Password is not valid");
            }
            else if (element.FindElements(By.CssSelector("span[id='error-element-password']")).Count != 0)
            {
                Console.WriteLine("Wrong email or password");
            }
        }

        public void RunSingUp(string email, string password)
        {
            Start();

            SingUp();

            IWebElement emailInput = FindEmailElement();
            if (emailInput != null)
            {
                try
                {
                    emailInput.SendKeys(email);
                    Console.WriteLine($"Username was sent: {email}");
                }
                catch
                {
                    Console.WriteLine("Wrong email");
                }
            }
            else Console.WriteLine("Element input-email wasn't available");

            SubmitSingUpClick();

            try
            {
                IWebElement passwordInput = FindSingUpPasswordElement();
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

                SubmitSingUpClick();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Finish();

        }

        public void RunLogIn(string username, string password)
        {
            Start();

            IWebElement usernameInput = FindEmailElement();
            if (usernameInput != null)
            {
                try
                {
                    usernameInput.SendKeys(username);
                    Console.WriteLine($"Username was sent: {username}");
                }
                catch
                {
                    Console.WriteLine("Username wasn't sent");
                }
            }
            else Console.WriteLine("Element input-email wasn't available");

            SubmitSingUpClick();
            try
            {
                IWebElement passwordInput = FindLogInPasswordElement();
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

                SubmitSingUpClick();

                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Finish();
        }
        public abstract IWebElement FindEmailElement();

        public abstract IWebElement FindSingUpPasswordElement();

        public abstract IWebElement FindLogInPasswordElement();
    }

}

