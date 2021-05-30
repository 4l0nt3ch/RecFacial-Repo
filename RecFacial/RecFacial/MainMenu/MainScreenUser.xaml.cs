using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace RecFacial.MainMenu
{
    public partial class MainScreenUser : ContentPage
    {
        public MainScreenUser()
        {
            InitializeComponent();
        }

        private void FacialRecognitionButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecFacial.FacialRecognitionLib.FacialRecognition());
        }

        private void QRCodeButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecFacial.QRCodeLib.QRcode());
        }
        private void LogoutButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AccountControl.Login());
        }
        public void EnterpriseInfoAccessClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecFacial.EnterpriseInformation.EntInfoPage());
        }
        private void ReportFormButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecFacial.ReportGesture.ReportForm());
        }
        private void ReportListSelectorButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecFacial.ReportGesture.ReportListSelector());
        }
    }
}
