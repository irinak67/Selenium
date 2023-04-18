using System.Collections.Generic;

namespace Selenium_GallerU_AUTH0
{
    class UserDetailes
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    internal class Scripts
    {
        private readonly string correctName = "forbesttesting8@gmail.com";
        private string correctPassword = "Test$2606";
        FindElement findElement = new FindElement();


        public void CheckSingUp(string email, string password)
        {
            findElement.RunSingUp(email, password);
        }

        public void CheckLogIn(string email, string password)
        {
            findElement.RunLogIn(email, password);
        }

        public void RunLoginSingUp()
        {
            string uncorrectName = correctName.Replace("@", "");
            string newName = correctName.Replace("ing8", "ing777");
            string uncorrectPassword = correctName.Replace("Test$", "test");

            Queue<UserDetailes> userDetailesLogin = new Queue<UserDetailes>();
            Queue<UserDetailes> userDetailesSingUp = new Queue<UserDetailes>();

            userDetailesLogin.Enqueue(new UserDetailes() { email = uncorrectName, password = correctPassword });
            userDetailesLogin.Enqueue(new UserDetailes() { email = newName, password = correctPassword });
            userDetailesLogin.Enqueue(new UserDetailes() { email = correctName, password = uncorrectPassword });
            userDetailesLogin.Enqueue(new UserDetailes() { email = correctName, password = correctPassword });

            userDetailesSingUp.Enqueue(new UserDetailes() { email = newName, password = correctPassword });
            userDetailesSingUp.Enqueue(new UserDetailes() { email = uncorrectName, password = correctPassword });


            while (userDetailesLogin.Count > 0)
            {
                var user = userDetailesLogin.Dequeue();
                CheckLogIn(user.email, user.password);
            }

            while (userDetailesSingUp.Count > 0)
            {
                var user = userDetailesSingUp.Dequeue();
                CheckSingUp(user.email, user.password);
            }
        }
    }
}
