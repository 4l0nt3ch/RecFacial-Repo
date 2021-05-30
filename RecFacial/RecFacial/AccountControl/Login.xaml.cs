using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RecFacial.AccountControl
{
    public partial class Login : ContentPage
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AccountControl.Register());
        }
        private void LoginButtonClicked(object sender, EventArgs e) {
            String username = EMPLOYEE_CODE.Text;
            String password = PASSWORD.Text;
                if (username.Equals("admin") && password.Equals("123"))
                {
                    Navigation.PushAsync(new MainMenu.MainScreenAdmin());
                }
                else if (username.Equals("default") && password.Equals("null"))
                {
                    Navigation.PushAsync(new MainMenu.MainScreenUser());
                }
        }

        private void RecoverButtonClicked(object sender, EventArgs e) {
            Navigation.PushAsync(new AccountControl.Recover());
        }

        public void GenerateEmployee() { 
            
        }
    }
}
