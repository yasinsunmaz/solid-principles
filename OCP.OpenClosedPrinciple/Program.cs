using OCP.OpenClosedPrinciple.InappropriateOCP;
using OCP.OpenClosedPrinciple.SuitableOCP;
using OCP.OpenClosedPrinciple.SuitableOCP.Banks;

//TODO: Inappropriate OCP - Uygunsuz OCP
Console.WriteLine("**** Inappropriate OCP - Uygunsuz OCP ****");
BankTransactions bankTransactions = new BankTransactions();
bankTransactions.SendMoney(500);

Console.WriteLine();

//TODO: Suitable OCP - Uygun OCP
Console.WriteLine("**** Suitable OCP - Uygun OCP ****");

BankTransactionsOCP bankTransactionsOCP = new BankTransactionsOCP();
Console.WriteLine("** Ziraat Bankasından Para Gönderme");
bankTransactionsOCP.SendMoney(new ZiraatOCP(), 700, "1234567890");
Console.WriteLine("** Garanti Bankasından Para Gönderme");
bankTransactionsOCP.SendMoney(new GarantiOCP(), 250, "1234567890");