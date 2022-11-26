namespace DIP.DependencyInversionPrinciple.InappropriateDIP.EmailServers
{
  public class Hotmail
  {
    public void Send(string email)
    {
      Console.WriteLine("Hotmail mail gönderildi. E-posta= " + email);
    }
  }
}