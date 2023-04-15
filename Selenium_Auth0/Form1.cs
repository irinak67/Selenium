using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Windows.Forms;

namespace Selenium_Auth0
{
    public partial class Form1 : Form
    {
        private static IWebDriver driver;
        private readonly string correctName = "forbesttesting@gmail.com";
        private string correctPassword = "Test$2606";
        public Form1()
        {
            InitializeComponent();
        }

        public void Pause(int mili = 3000)
        {
            System.Threading.Thread.Sleep(mili);
        }

        private void Start()
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

        private void SingUp()
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

        private void Finish()
        {
            if (driver != null) driver.Close();
        }

        private void AlertOfError(IWebDriver element)
        {
            if (element.FindElements(By.CssSelector("div[id='prompt-alert']")).Count != 0) Console.WriteLine("Something went wrong, please try again later");
            else if (element.FindElements(By.CssSelector("span[id='error-element-email']")).Count != 0) Console.WriteLine("Email is not valid");
            else if (element.FindElements(By.CssSelector("div[class='cb7ca42d5']")).Count != 0) Console.WriteLine("Password is not valid");
            else if (element.FindElements(By.CssSelector("span[id='error-element-password']")).Count != 0) Console.WriteLine("Wrong email or password");
        }

        // Sing Up with Correct email & password
        private void button1_Click(object sender, EventArgs e)
        {
            Start();

            SingUp();

            IWebElement nameInput = driver.FindElement(By.CssSelector("input[name='email']"));
            if (nameInput != null)
            {
                try
                {
                    nameInput.SendKeys(correctName);
                    Console.WriteLine($"Username was sent: {correctName}");
                }
                catch
                {
                    Console.WriteLine("Wrong email");
                }
            }
            else Console.WriteLine("Element input-email wasn't available");

            IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
            if (passwordInput != null)
            {
                try
                {
                    passwordInput.SendKeys(correctPassword);
                    Console.WriteLine($"Password was sent = {correctPassword}");
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

        // Sing Up with with Uncorrect email & Correct password  
        private void button3_Click(object sender, EventArgs e)
        {
            Start();

            SingUp();

            IWebElement nameInput = driver.FindElement(By.CssSelector("input[name='email']"));
            if (nameInput != null)
            {
                try
                {
                    string uncorrectName = correctName.Replace("@", "");
                    nameInput.SendKeys(uncorrectName);
                    Console.WriteLine($"Username was sent: {uncorrectName}");
                }
                catch
                {
                    Console.WriteLine("Username wasn't sent");
                }
            }
            else Console.WriteLine("Element input-email wasn't available");

            IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
            if (passwordInput != null)
            {
                try
                {
                    passwordInput.SendKeys(correctPassword);
                    Console.WriteLine($"Password was sent = {correctPassword}");
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

        // Sing Up with Correct email & Uncorrect password   
        private void button5_Click(object sender, EventArgs e)
        {
            Start();

            SingUp();

            IWebElement nameInput = driver.FindElement(By.CssSelector("input[name='email']"));
            if (nameInput != null)
            {
                try
                {
                    string correctNameNew = correctName.Replace("ing", "ing1");
                    nameInput.SendKeys(correctNameNew);
                    Console.WriteLine($"Username was sent: {correctNameNew}");
                }
                catch
                {
                    Console.WriteLine("Username wasn't sent");
                }
            }
            else Console.WriteLine("Element input-email wasn't available");

            IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
            if (passwordInput != null)
            {
                try
                {
                    string uncorrectPassword = correctPassword.Replace("Test$", "test");
                    passwordInput.SendKeys(uncorrectPassword);
                    Console.WriteLine($"Password was sent = {uncorrectPassword}");
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

        // Log In with Correct email & Correct password  
        private void button2_Click(object sender, EventArgs e)
        {
            Start();

            IWebElement nameInput = driver.FindElement(By.CssSelector("input[name='username']"));
            if (nameInput != null)
            {
                try
                {
                    nameInput.SendKeys(correctName);
                    Console.WriteLine($"Username was sent: {correctName}");
                }
                catch
                {
                    Console.WriteLine("Username wasn't sent");
                }
            }
            else Console.WriteLine("Element input-email wasn't available");

            IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
            if (passwordInput != null)
            {
                try
                {
                    passwordInput.SendKeys(correctPassword);
                    Console.WriteLine($"Password was sent = {correctPassword}");
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

        // Log In with Uncorrect email & Correct password   
        private void button4_Click(object sender, EventArgs e)
        {
            Start();

            IWebElement nameInput = driver.FindElement(By.CssSelector("input[name='username']"));
            if (nameInput != null)
            {
                try
                {
                    string uncorrectName = correctName.Replace("ing", "ing9");
                    nameInput.SendKeys(uncorrectName);
                    Console.WriteLine($"Username was sent: {uncorrectName}");
                }
                catch
                {
                    Console.WriteLine("Username wasn't sent");
                }
            }
            else Console.WriteLine("Element input-email wasn't available");

            IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
            if (passwordInput != null)
            {
                try
                {
                    passwordInput.SendKeys(correctPassword);
                    Console.WriteLine($"Password was sent = {correctPassword}");
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

        // Log In with Correct email & Uncorrect password   
        private void button6_Click(object sender, EventArgs e)
        {
            Start();

            IWebElement nameInput = driver.FindElement(By.CssSelector("input[name='username']"));
            if (nameInput != null)
            {
                try
                {
                    nameInput.SendKeys(correctName);
                    Console.WriteLine($"Username was sent: {correctName}");
                }
                catch
                {
                    Console.WriteLine("Username wasn't sent");
                }

            }
            else Console.WriteLine("Element input-email wasn't available");

            IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
            if (passwordInput != null)
            {
                try
                {
                    string uncorrectPassword = correctPassword.Replace("Test$", "test");
                    passwordInput.SendKeys(uncorrectPassword);
                    Console.WriteLine($"Password was sent = {uncorrectPassword}");
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
    }
}
