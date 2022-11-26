using SRP.SingleResponsibilityPrinciple.InappropriateSRP;
using SRP.SingleResponsibilityPrinciple.SuitableSRP;

//TODO: Inappropriate SRP - Uygunsuz SRP
Console.WriteLine("**** Inappropriate SRP - Uygunsuz SRP ****");
Database db = new Database();
db.Connect();
db.GetPersons();

Console.WriteLine("*** Tüm Kişi Listesi ***");
foreach (var item in db.GetPersons())
{
  Console.WriteLine(item.FirstName);
}

Console.WriteLine("** Kişi Bul **");

//SRP uygun olmayan bir durum. Kişi listesi üzerinden biri çekmek. Sebebi bu durumu sürekli yaptığınız kod maliyeti artar.
var personNotIdeal = db.GetPersons().Where(x => x.Id == 1).FirstOrDefault();
string firstNameNotIdeal = personNotIdeal.FirstName;
string lastNameNotIdeal = personNotIdeal.LastName;

//SRP metot düzeyinde doğru bir kullanım. Çünkü kişiyi getiren bir metot var. Oldukça basit ve anlaşılır.
//Fakat sorun db üzerinden bu metota erişiyor olmamızdır.
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

Console.WriteLine("*** Tüm Kişi Listesi ***");
foreach (var item in personService.GetPersons())
{
  Console.WriteLine(item.FirstName);
}

Console.WriteLine("** Kişi Bul **");
var personInfo = personService.GetPersonInfo(1);
if (personInfo.Id > 0)
{
  Console.WriteLine("* Bulunan Kişi: " + personInfo.FirstName + " " + personInfo.LastName);
}
else
{
  Console.WriteLine("Kişi bulunamadı");
}
dbService.Disconnect();

///<summary>
///SRP örneklerde görüldüğü üzere amaç satır, metot ve sınıf düzeyinde tek bir sorumluluğu yerine getirmesi esastır.
///Satır 52'deki kullanım satır düzeyinde doğru bir kullanımdır.
///Satır 19'daki kullanıma göre satır 25'deki kullanım metot düzeyinde doğru bir kullanımdır.
///Satır 25'deki kullanıma göre satır 52'deki kullanım sınıf düzeyinde doğru bir kullanımdır.
/// </summary>