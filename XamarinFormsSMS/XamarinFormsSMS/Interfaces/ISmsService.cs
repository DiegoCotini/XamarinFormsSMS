
namespace XamarinFormsSMS.Interfaces
{
    public interface ISmsService
    {
        void SendSMS(string phoneNumber, string text);
    }
}
