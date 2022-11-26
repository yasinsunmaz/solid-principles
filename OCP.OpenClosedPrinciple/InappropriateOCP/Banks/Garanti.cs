namespace OCP.OpenClosedPrinciple.InappropriateOCP.Banks
{
  public class Garanti
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
  }
}