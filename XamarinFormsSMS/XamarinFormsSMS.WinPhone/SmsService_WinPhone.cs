using Xamarin.Forms.Platform.WinRT;
using XamarinFormsSMS.Interfaces;
using XamarinFormsSMS.WinPhone;

[assembly: Xamarin.Forms.Dependency(typeof(SmsService_WinPhone))]

namespace XamarinFormsSMS.WinPhone
{
    public class SmsService_WinPhone : ISmsService
    {
        public void SendSMS(string phoneNumber, string text)
        {
            var chatMessage = new Windows.ApplicationModel.Chat.ChatMessage();
            chatMessage.Body = text;
            chatMessage.Recipients.Add(phoneNumber);

            Windows.ApplicationModel.Chat.ChatMessageManager.ShowComposeSmsMessageAsync(chatMessage);
        }
    }
}
