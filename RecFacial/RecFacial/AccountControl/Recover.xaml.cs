using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RecFacial.AccountControl
{
    public partial class Recover : ContentPage
    {
        public Recover()
        {
            InitializeComponent();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AccountControl.Login());
        }
        private void LoginButtonClicked(object sender, EventArgs e) {
            Navigation.PushAsync(new AccountControl.Register());
        }
    }
}
