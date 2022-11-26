using OCP.OpenClosedPrinciple.SuitableOCP.Interfaces;

namespace OCP.OpenClosedPrinciple.SuitableOCP.Banks
{
  public class ZiraatOCP : IBankTransaction
  {
    public string? CustomerAccountNumber { get; set; }

    public void SendMoney(int price)
    {
      //Hesap numarasını kontrol işlemleri yapmıyor
      Console.WriteLine("Ziraat Bankası-Para Gönderildi. Tutar= " + price);
    }

    public bool BankTransaction(int price, string customerAccountNumber)
    {
      try
      {
        CustomerAccountNumber = customerAccountNumber;
        SendMoney(price);
        return true;
      }
      catch
      {
        return false;
      }
    }
  }
}