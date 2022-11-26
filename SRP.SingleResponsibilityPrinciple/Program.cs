using SRP.SingleResponsibilityPrinciple.InappropriateSRP;
using SRP.SingleResponsibilityPrinciple.SuitableSRP;

//TODO: Inappropriate SRP - Uygunsuz SRP
Console.WriteLine("**** Inappropriate SRP - Uygunsuz SRP ****");
Database db = new Database();
db.Connect();
db.GetPersons();

Console.WriteLine("* Tüm Kişi Listesi *");
foreach (var item in db.GetPersons())
{
  Console.WriteLine(item.FirstName);
}

Console.WriteLine("* Kişi Bul *");
var person = db.GetPersonInfo(1);
if (person.Id > 0)
{
  Console.WriteLine("* Bulunan Kişi: " + person.FirstName + " " + person.LastName);
}
else
{
  Console.WriteLine("Kişi bulunamadı");
}
db.Disconnect();

Console.WriteLine();

//TODO: Suitable SRP - Uygun SRP
Console.WriteLine("**** Suitable SRP - Uygun SRP ****");
DatabaseService dbService = new DatabaseService();
dbService.Connect();

PersonService personService = new PersonService();

Console.WriteLine("* Tüm Kişi Listesi **");
foreach (var item in personService.GetPersons())
{
  Console.WriteLine(item.FirstName);
}

Console.WriteLine("** Kişi Bul **");
var presonInfo = personService.GetPersonInfo(1);
if (presonInfo.Id > 0)
{
  Console.WriteLine("* Bulunan Kişi: " + presonInfo.FirstName + " " + presonInfo.LastName);
}
else
{
  Console.WriteLine("Kişi bulunamadı");
}
dbService.Disconnect();