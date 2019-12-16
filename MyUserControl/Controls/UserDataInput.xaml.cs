using MyUserControl.Models;
using Windows.UI.Xaml.Controls;


namespace MyUserControl.Controls
{
    public sealed partial class UserDataInput : UserControl
    {
        private User _user;

        public User UserData
        {
            get { return _user; }
            set { 
                _user = value;
                UserName.Text = _user?.Name ?? "";
                UserAge.Text = _user?.Age.ToString() ?? "0";
            }
        }

        public UserDataInput()
        {
            this.InitializeComponent();
        }
    }
}
