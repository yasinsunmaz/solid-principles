using DIP.DependencyInversionPrinciple.SuitableDIP.Interfaces;

namespace DIP.DependencyInversionPrinciple.InappropriateDIP.EmailServers
{
  public class GmailDIP : IEmailService
  {
    public void Send(string to, string body)
    {
      Console.WriteLine("Gmail mail gönderildi. Kime= " + to + " İçerik= " + body);
    }
  }
}