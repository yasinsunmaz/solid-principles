namespace DIP.DependencyInversionPrinciple.SuitableDIP.Interfaces
{
  public interface IEmailService
  {
    void Send(string to, string body);
  }
}