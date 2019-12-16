using MyUserControl.Models;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace MyUserControl
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var u1 = new User { Name = "Billy Bob", Age = 34 };
            var u2 = new User { Name = "Anna Bob", Age = 23 };
            var u3 = new User { Name = "David Bob", Age = 45 };
            var u4 = new User { Name = "Sue Bob", Age = 67 };
            List<User> users = new List<User> { u1, u2, u3, u4 };
            foreach (var user in users)
            {
                Users.Items.Add(user);
            }
        }

        private void Users_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var userItem = ((ListView)sender).SelectedItem;
            var user = userItem as User;
            UserDataControl.UserData = user;
            //UserName.Text = user.Name;
            //UserAge.Text = user.Age.ToString();
        }
    }
}
