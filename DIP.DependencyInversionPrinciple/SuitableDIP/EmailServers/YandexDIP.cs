using DIP.DependencyInversionPrinciple.SuitableDIP.Interfaces;

namespace DIP.DependencyInversionPrinciple.InappropriateDIP.EmailServers
{
  public class YandexDIP : IEmailService
  {
    public void Send(string to, string body)
    {
      Console.WriteLine("Yandex mail gönderildi. Kime= " + to + " İçerik= " + body);
    }
  }
}