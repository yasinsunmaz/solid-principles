using DIP.DependencyInversionPrinciple.SuitableDIP.Interfaces;

namespace DIP.DependencyInversionPrinciple.SuitableDIP
{
  public class EmailServiceDIP
  {
    public void SendEmail(IEmailService emailServer, string to, string body)
    {
      emailServer.Send(to, body);
    }
  }
}