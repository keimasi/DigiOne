namespace _0_Framwork.Application.Sms
{
    public interface ISmsService
    {
        void Send(string number, string message);
    }
}
