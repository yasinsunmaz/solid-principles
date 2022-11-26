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
emailServiceDIP.SendMail(new GmailDIP(), "contact@yasinsunmaz.com", "Merhaba Dünya");
emailServiceDIP.SendMail(new HotmailDIP(), "contact@yasinsunmaz.com", "Güle Güle Dünya");
emailServiceDIP.SendMail(new YandexDIP(), "contact@yasinsunmaz.com", "Elveda Dünya");