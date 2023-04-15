using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Pause(int mili = 3000)
        {
            System.Threading.Thread.Sleep(mili);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 11; i <= 20; i++)
            {
                string name = "irina_" + i;
                string email = "test_" + i + "@gmail.com";
                string url = "https://zionet-selenium.bubbleapps.io/version-test";
                using (IWebDriver driver = new ChromeDriver())
                {
                    driver.Navigate().GoToUrl(url);
                    driver.Manage().Window.Maximize();
                    Pause();
                    IWebElement signUpBtn = driver.FindElement(By.CssSelector("div[class='clickable-element bubble-element Group baTaGzaS bubble-r-container flex row']"));
                    if (signUpBtn != null)
                    {
                        signUpBtn.Click();
                        Pause();

                        IWebElement nameInput = driver.FindElement(By.CssSelector("input[placeholder='Username']"));
                        if (nameInput != null)
                        {
                            nameInput.SendKeys(name);
                        }

                        IWebElement emailInput = driver.FindElement(By.CssSelector("input[placeholder='Email Address']"));
                        if (emailInput != null)
                        {
                            emailInput.SendKeys(email);
                        }

                        IWebElement passwordInput = driver.FindElement(By.CssSelector("input[placeholder='Password']"));
                        if (passwordInput != null)
                        {
                            passwordInput.SendKeys("test$12345");
                        }

                        IWebElement confirmPasswordInput = driver.FindElement(By.CssSelector("input[placeholder='Confirm Password']"));
                        if (confirmPasswordInput != null)
                        {
                            confirmPasswordInput.SendKeys("test$12345");
                        }

                        IWebElement submitBtn = driver.FindElement(By.CssSelector("div[class='bubble-element Text baTaHaMaI clickable-element bubble-r-vertical-center']"));
                        if (submitBtn != null)
                        {
                            submitBtn.Click();
                            Pause();
                            driver.Quit();
                        }
                    }

                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime();
            dt1 = DateTime.Now;

            DateTime dt2 = new DateTime();
            dt2 = DateTime.Now;

            TimeSpan ts1 = new TimeSpan(dt1.Ticks);
            TimeSpan ts2 = new TimeSpan(dt2.Ticks);

            TimeSpan ts3 = ts2 - ts1;
            
            string url = "https://zionet-selenium.bubbleapps.io/version-test";

            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(url);
                Pause();
                IWebElement aTag = driver.FindElement(By.Id("rJUDFxBO112"));

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                wait.Until<int>((d) => {
                driver.Navigate().GoToUrl("www.google.com"); 
                return 0;
            }) ;
                
                IWebElement b = wait.Until<IWebElement>((d) => { return d.FindElement(By.Id("sss")); });

                if (aTag != null)
                {
                    aTag.Click();
                    aTag.SendKeys("blalbla");

                }

            }
        }
    }
}

