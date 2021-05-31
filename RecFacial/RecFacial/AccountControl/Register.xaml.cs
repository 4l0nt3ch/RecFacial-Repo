using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using RecFacial.DatabaseDriver.EmployeeData;

namespace RecFacial.AccountControl
{
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        async void ChooseImageButtonClicked(object sender, EventArgs e)
        {
            var photoResult = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Por favor escoge una foto"
            });

            if (photoResult != null)
            {
                var streamResult = await photoResult.OpenReadAsync();
                resultImage.Source = ImageSource.FromStream(() => streamResult);
            }
        }
        async void TakePhotoButtonClicked(object sender, EventArgs e)
        {
            var photoResult = await MediaPicker.CapturePhotoAsync();

            if (photoResult != null)
            {
                var streamResult = await photoResult.OpenReadAsync();
                resultImage.Source = ImageSource.FromStream(() => streamResult);
            }
        }
    }
}
