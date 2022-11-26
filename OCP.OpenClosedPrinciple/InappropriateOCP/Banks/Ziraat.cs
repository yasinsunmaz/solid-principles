namespace OCP.OpenClosedPrinciple.InappropriateOCP.Banks
{
  public class Ziraat
  {
    public string? CustomerAccountNo { get; set; }

    public void SendMoney(int price)
    {
      //Hesap numarasını kontrol işlemleri yapmıyor
      Console.WriteLine("Ziraat Bankası-Para Gönderildi. Tutar= " + price);
    }
  }
}