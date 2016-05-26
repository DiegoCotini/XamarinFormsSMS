using Android.Telephony;
using XamarinFormsSMS.Droid;
using XamarinFormsSMS.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(SmsService_Android))]

namespace XamarinFormsSMS.Droid
{
    public class SmsService_Android : ISmsService
    {
        public void SendSMS(string phoneNumber, string text)
        {
            SmsManager.Default.SendTextMessage(phoneNumber, null, text, null, null);
        }
    }
}