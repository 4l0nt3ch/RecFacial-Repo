using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using RecFacial.DatabaseDriver.Models;
using RecFacial.DatabaseDriver.Management;

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
                IM_USER_IMAGE.Source = ImageSource.FromStream(() => streamResult);
            }
        }
        async void TakePhotoButtonClicked(object sender, EventArgs e)
        {
            var photoResult = await MediaPicker.CapturePhotoAsync();

            if (photoResult != null)
            {
                var streamResult = await photoResult.OpenReadAsync();
                IM_USER_IMAGE.Source = ImageSource.FromStream(() => streamResult);
            }
        }
        async void CancelButtonClicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new RecFacial.AccountControl.Login());
        }
        async void EmpSubmit(object sender, EventArgs e) {
        try { 
                EmpModel empModel = new EmpModel();             
                empModel.FirstName = TXT_FIRST_NAME.Text.ToString();
                empModel.LastName = TXT_LAST_NAME.Text.ToString();
                empModel.Age = Int32.Parse(TXT_AGE.Text.ToString());
                empModel.Address = TXT_ADDRESS.Text.ToString();
                empModel.DOB = DP_DOB.Date.ToString();
                empModel.Email = TXT_EMAIL.Text.ToString();
                empModel.Password = TXT_PASSWORD.Text.ToString();
                empModel.EntName = TXT_ENT_NAME.Text.ToString();
                empModel.Role = PCK_ROLE.SelectedItem.ToString();
                empModel.DateOrigin = DP_DATE_ORIGIN.Date.ToString();
                empModel.Department = PCK_DEPARTMENT.SelectedItem.ToString();
                empModel.Branch = PCK_BRANCH.SelectedItem.ToString();
                empModel.UserName = TXT_USER_NAME.Text.ToString();
                empModel.UserType = PCK_USER_TYPE.SelectedItem.ToString();
                await App.MCHelper.EmpCreate(empModel);
                await DisplayAlert("Correcto", "Inscripción realizada correctamente", "Ok");
                await Navigation.PushAsync(new RecFacial.AccountControl.Login());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Inscripción de Empleado Errónea", "Se ha producido un error de inscripción, Ingrese y verifique TOODS sus datos e intente de nuevo: " + ex.StackTrace, "Ok");
            }
        }
       bool DataVerify()
        {
            bool[] globalBoolVerify = new bool[9];
            globalBoolVerify[0] = DataFieldVerify(TXT_FIRST_NAME);
            globalBoolVerify[1] = DataFieldVerify(TXT_LAST_NAME);
            globalBoolVerify[2] = DataFieldVerify(TXT_AGE);
            globalBoolVerify[3] = DataFieldVerify(TXT_ADDRESS);
            globalBoolVerify[4] = DataFieldVerify(TXT_EMAIL);
            globalBoolVerify[5] = DataFieldVerify(TXT_PASSWORD);
            globalBoolVerify[6] = DataFieldVerify(TXT_PASSWORD_CONF);
            globalBoolVerify[7] = DataFieldVerify(TXT_ENT_NAME);
            globalBoolVerify[8] = DataFieldVerify(TXT_USER_NAME);

            for (int i = 0; i < 9; i++)
            {
                if (globalBoolVerify[i] == true)
                {
                    break;
                }
            }
            return false;
        }
        bool DataFieldVerify(Entry txtEntry)
        {
            bool verifyStatus;
            if (string.IsNullOrEmpty(txtEntry.Text))
            {
                verifyStatus = false;
            }
            else
            {
                verifyStatus = true;
            }
            return verifyStatus;
        }
    }
}
