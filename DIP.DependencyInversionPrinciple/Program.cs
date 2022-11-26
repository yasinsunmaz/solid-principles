using DIP.DependencyInversionPrinciple.InappropriateDIP;
using DIP.DependencyInversionPrinciple.InappropriateDIP.EmailServers;
using DIP.DependencyInversionPrinciple.SuitableDIP;

//TODO: Inappropriate DIP - Uygunsuz DIP
Console.WriteLine("**** Inappropriate DIP - Uygunsuz DIP ****");
EmailService emailService = new();
emailService.SendEmail(new Gmail());

Console.WriteLine();

//TODO: Suitable DIP - Uygun DIP
Console.WriteLine("**** Suitable DIP - Uygun DIP ****");
EmailServiceDIP emailServiceDIP = new();
emailServiceDIP.SendEmail(new GmailDIP(), "contact@yasinsunmaz.com", "Merhaba Dünya");
emailServiceDIP.SendEmail(new HotmailDIP(), "contact@yasinsunmaz.com", "Güle Güle Dünya");
emailServiceDIP.SendEmail(new YandexDIP(), "contact@yasinsunmaz.com", "Elveda Dünya");

///<summary>
///DIP örneklerde görüldüğü üzere amaç satır 8'deki durumda SendEmail Gmail nesnesine bağlıdır.
///Fakat satır 15-17'deki kullanımlarda ise tam tersi SendEmail nesneye bağımlı değildir. Nesneler SendEmail'e bağımlıdır. Böylece
///Satır 8'deki kullanıma göre satır 15-17'deki kullanım DIP'e uygun doğru bir kullanımdır.
/// </summary>