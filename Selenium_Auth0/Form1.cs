using System;
using System.Windows.Forms;

namespace Selenium_Auth0
{
    public partial class Form1 : Form
    {
        private readonly string correctName = "forbesttesting10@gmail.com";
        private string correctPassword = "Test$2606";
        public Form1()
        {
            InitializeComponent();
        }

        // Sing Up with Correct email & password
        private void button1_Click(object sender, EventArgs e)
        {
            testElement test = new testElement();
            test.RunSingUp(correctName, correctPassword);
        }

        // Sing Up with with Uncorrect email & Correct password  
        private void button3_Click(object sender, EventArgs e)
        {
            string uncorrectName = correctName.Replace("@", "");
            testElement test = new testElement();
            test.RunSingUp(uncorrectName, correctPassword);
        }

        // Sing Up with Correct email & Uncorrect password   
        private void button5_Click(object sender, EventArgs e)
        {
            string uncorrectPassword = correctPassword.Replace("Test$", "test");
            testElement test = new testElement();
            test.RunSingUp(correctName, uncorrectPassword);
        }

        // Log In with Correct email & Correct password  
        private void button2_Click(object sender, EventArgs e)
        {
            testElement test = new testElement();
            test.RunLogIn(correctName, correctPassword);
        }

        // Log In with Uncorrect email & Correct password   
        private void button4_Click(object sender, EventArgs e)
        {
            string uncorrectName = correctName.Replace("@", "");
            testElement test = new testElement();
            test.RunLogIn(uncorrectName, correctPassword);
        }

        // Log In with Correct email & Uncorrect password   
        private void button6_Click(object sender, EventArgs e)
        {
            string uncorrectPassword = correctPassword.Replace("Test$", "test");
            testElement test = new testElement();
            test.RunLogIn(correctName, uncorrectPassword);
        }
    }
}
