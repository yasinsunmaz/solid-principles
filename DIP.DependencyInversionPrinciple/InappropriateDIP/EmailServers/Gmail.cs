namespace DIP.DependencyInversionPrinciple.InappropriateDIP.EmailServers
{
  public class Gmail
  {
    public void Send(string email)
    {
      Console.WriteLine("Gmail mail gönderildi. E-posta= " + email);
    }
  }
}