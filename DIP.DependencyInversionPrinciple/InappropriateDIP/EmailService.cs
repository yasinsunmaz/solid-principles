using DIP.DependencyInversionPrinciple.InappropriateDIP.EmailServers;

namespace DIP.DependencyInversionPrinciple.InappropriateDIP
{
  //TODO: Inappropriate DIP - Uygunsuz DIP
  public class EmailService
  {
    public void SendEmail(Gmail gmail)
    {
      gmail.Send("contact@yasinsunmaz.com");
    }
  }
}