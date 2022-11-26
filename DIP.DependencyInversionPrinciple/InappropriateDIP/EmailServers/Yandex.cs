namespace DIP.DependencyInversionPrinciple.InappropriateDIP.EmailServers
{
  public class Yandex
  {
    public void SendEmail(string email, string to)
    {
      Console.WriteLine("Yandex mail gönderildi. Gönderici= " + email + " Alıcı= " + to);
    }
  }
}