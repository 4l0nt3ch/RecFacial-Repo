using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using ZXing.Net.Mobile.Forms;

namespace RecFacial.QRCodeLib
{
    public partial class QRcode : ContentPage
    {
        ZXingBarcodeImageView qrObject;
        public QRcode()
        {
            InitializeComponent();
        }
        private async void GenerateQRButtonClicked(object sender, EventArgs e)
        {
            qrObject = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            qrObject.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
            qrObject.BarcodeOptions.Width = 300;
            qrObject.BarcodeOptions.Height = 300;
            qrObject.BarcodeValue = "QR_CODE_001";
            if (resultImage.Children.Count < 1)
            {
                resultImage.Children.Add(qrObject);
            }
            else {
                Console.WriteLine("Ya se genero tu QR");
            }
        }
    }
}

