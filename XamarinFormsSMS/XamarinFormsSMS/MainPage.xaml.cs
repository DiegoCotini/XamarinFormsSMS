using System;
using Xamarin.Forms;
using XamarinFormsSMS.Exceptions;
using XamarinFormsSMS.Interfaces;

namespace XamarinFormsSMS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void SendSMS_Click(object sender, EventArgs e)
        {
            try
            {
                ValidadeEntries();

                var smsService = DependencyService.Get<ISmsService>();
                smsService.SendSMS(PhoneNumber.Text, Text.Text);
            }
            catch (ValidateException ex)
            {
                DisplayAlert("Alert", ex.Message, "OK");
            }
            catch
            {
                DisplayAlert("Error", "Sorry, an unexpected error occurred", "OK");
            }                
        }

        private void ValidadeEntries()
        {
            if (string.IsNullOrWhiteSpace(PhoneNumber.Text))
                throw new ValidateException("Enter a valid phone number");

            if (string.IsNullOrWhiteSpace(Text.Text))
                throw new ValidateException("Enter a text");
        }
    }
}
