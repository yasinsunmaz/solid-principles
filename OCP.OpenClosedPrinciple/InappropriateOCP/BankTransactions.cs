using OCP.OpenClosedPrinciple.InappropriateOCP.Banks;

namespace OCP.OpenClosedPrinciple.InappropriateOCP
{
  //TODO: Inappropriate OCP - Uygunsuz OCP
  public class BankTransactions
  {
    public void SendMoney(int price)
    {
      //Ziraat Bankası Para Gönderme Şekli
      Ziraat ziraat = new Ziraat();
      ziraat.CustomerAccountNo = "1234567890";
      ziraat.SendMoney(price);

      //Garanti Bankası Para Gönderme Şekli
      Garanti garanti = new Garanti();
      garanti.AccountNumberToSend("1234567890");
      garanti.SendMoney(price);
    }
  }
}