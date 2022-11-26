using OCP.OpenClosedPrinciple.SuitableOCP.Interfaces;

namespace OCP.OpenClosedPrinciple.SuitableOCP.Banks
{
  public class GarantiOCP : IBankTransaction
  {
    private string _customerAccountNo;

    public void AccountNumberToSend(string _customerAccountNo)
    {
      //Hesap numarasını kontrol işlemleri yapıyor
      Console.WriteLine("Garanti Bankası-Gönderilecek Hesap Numarası. Hesap No= " + _customerAccountNo);
    }

    public void SendMoney(int price)
    {
      Console.WriteLine("Garanti Bankası-Para Gönderildi. Tutar= " + price);
    }

    public bool BankTransaction(int price, string customerAccountNumber)
    {
      try
      {
        AccountNumberToSend(customerAccountNumber);
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