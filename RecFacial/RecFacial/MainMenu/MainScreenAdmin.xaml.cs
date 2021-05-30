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
    public partial class MainScreenAdmin : ContentPage
    {
        public MainScreenAdmin()
        {
            InitializeComponent();
        }

        private void FacialRecognitionButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecFacial.FacialRecognitionLib.FacialRecognition());
        }

        private void QRCodeRecongitionButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecFacial.QRCodeLib.QRcode());
        }
        private void LogoutButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecFacial.AccountControl.Login());
        }

        public void EnterpriseInfoAccessClicked(object sender, EventArgs e) {
            Navigation.PushAsync(new RecFacial.EnterpriseInformation.EntInfoPage());
        }

        private void AttendanceReportListButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecFacial.ReportGesture.AttendanceRepList());
        }
        
        private void ReportListSelectorButtonClicked(object sender, EventArgs e){
            Navigation.PushAsync(new RecFacial.ReportGesture.ReportListSelector());
        }
    }
}
