using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace RecFacial.FacialRecognitionLib
{
    public partial class FacialRecognition : ContentPage
    {
        public FacialRecognition()
        {
            InitializeComponent();
        }
        async void ChoosePhotoButtonClicked(object sender, EventArgs e)
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
        async void GeneratePhotoButtonClicked(object sender, EventArgs e)
        {
            var photoResult = await MediaPicker.CapturePhotoAsync();

            if (photoResult != null)
            {
                var streamResult = await photoResult.OpenReadAsync();
                resultImage.Source = ImageSource.FromStream(() => streamResult);
            }
        }
        async void SendPhotoButtonClicked(object sender, EventArgs e)
        {

        }
        public void ButtonReturn(object sender, EventArgs e)
        {

        }
    }

}
