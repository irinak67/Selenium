using NUnit.Framework;
using System;
using System.Windows.Forms;

namespace Selenium_GallerU_AUTH0
{
    public partial class Form1 : Form
    {
        private readonly string correctName = "forbesttesting8@gmail.com";
        private string correctPassword = "Test$2606";
        public Form1()
        {
            InitializeComponent();
        }

        // Sing Up - Correct email & password
        private void button1_Click(object sender, EventArgs e)
        {
            FindElement findElement = new FindElement();
            findElement.RunSingUp(correctName, correctPassword);
        }

        // Sing Up - with Uncorrect email & Correct password  
        private void button3_Click(object sender, EventArgs e)
        {
            string uncorrectName = correctName.Replace("@", "");
            FindElement findElement = new FindElement();
            findElement.RunSingUp(uncorrectName, correctPassword);
        }

        // Sing Up - Correct email & Uncorrect password   
        private void button5_Click(object sender, EventArgs e)
        {
            string uncorrectPassword = correctName.Replace("Test$", "test");
            FindElement findElement = new FindElement();
            findElement.RunSingUp(correctName, uncorrectPassword);
        }

        // Log In - Correct email & Correct password  
        private void button2_Click(object sender, EventArgs e)
        {
            FindElement findElement = new FindElement();
            findElement.RunLogIn(correctName, correctPassword);
        }

        // Log In - Uncorrect email & Correct password  
        private void button4_Click(object sender, EventArgs e)
        {
            string uncorrectName = correctName.Replace("@", "");
            FindElement findElement = new FindElement();
            findElement.RunLogIn(uncorrectName, correctPassword);
        }

        // Log In - Correct email & Uncorrect password  
        private void button6_Click(object sender, EventArgs e)
        {
            string uncorrectPassword = correctName.Replace("Test$", "test");
            FindElement findElement = new FindElement();
            findElement.RunLogIn(correctName, uncorrectPassword);
        }

        // Log In - don't exist email & Uncorrect password  
        private void button7_Click(object sender, EventArgs e)
        {
            string uncorrectName = correctName.Replace("ing8", "ing88");
            FindElement findElement = new FindElement();
            findElement.RunLogIn(uncorrectName, correctPassword);
        }
                
    }
}
