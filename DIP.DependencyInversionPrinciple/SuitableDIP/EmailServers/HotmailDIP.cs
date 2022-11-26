using DIP.DependencyInversionPrinciple.SuitableDIP.Interfaces;

namespace DIP.DependencyInversionPrinciple.InappropriateDIP.EmailServers
{
  public class HotmailDIP : IEmailService
  {
    public void Send(string to, string body)
    {
      Console.WriteLine("Hotmail mail gönderildi. Kime= " + to + " İçerik= " + body);
    }
  }
}