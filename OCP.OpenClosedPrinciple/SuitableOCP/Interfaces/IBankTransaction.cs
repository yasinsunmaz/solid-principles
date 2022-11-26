namespace OCP.OpenClosedPrinciple.SuitableOCP.Interfaces
{
  public interface IBankTransaction
  {
    bool BankTransaction(int price, string customerAccountNumber);
  }
}