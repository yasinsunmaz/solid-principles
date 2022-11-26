using DIP.DependencyInversionPrinciple.InappropriateDIP.EmailServers;

namespace DIP.DependencyInversionPrinciple.InappropriateDIP
{
  public class EmailService
  {
    public void SendEmail(Gmail gmail)
    {
      gmail.Send("contact@yasinsunmaz.com");
    }
  }
}