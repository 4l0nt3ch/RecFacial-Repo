using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RecFacial.EnterpriseInformation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntInfoPage : ContentPage
    {
        public EntInfoPage()
        {
            InitializeComponent();
        }
        public void ReturnBackMainMenuClicked(object sender, EventArgs e) {
            Navigation.PushAsync(new RecFacial.MainMenu.MainScreenUser());
        }
    }
}