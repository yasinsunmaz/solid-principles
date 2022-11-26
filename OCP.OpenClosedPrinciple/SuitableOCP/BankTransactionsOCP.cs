using OCP.OpenClosedPrinciple.SuitableOCP.Interfaces;

namespace OCP.OpenClosedPrinciple.SuitableOCP
{
  //TODO: Suitable OCP - Uygun OCP
  public class BankTransactionsOCP
  {
    public void SendMoney(IBankTransaction bank, int price, string customerAccountNumber)
    {
      bank.BankTransaction(price, customerAccountNumber);
    }
  }
}