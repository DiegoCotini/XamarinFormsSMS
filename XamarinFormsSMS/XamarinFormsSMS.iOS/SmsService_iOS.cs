using MessageUI;
using UIKit;
using XamarinFormsSMS.Interfaces;
using XamarinFormsSMS.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(SmsService_iOS))]

namespace XamarinFormsSMS.iOS
{
    public class SmsService_iOS : ISmsService
    {
        public void SendSMS(string phoneNumber, string text)
        {
            var composerViewController = new MFMessageComposeViewController()
            {
                Recipients = new[] { phoneNumber },
                Body = text,
            };

            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(composerViewController, true, null);
        }
    }
}