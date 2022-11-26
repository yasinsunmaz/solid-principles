using ISP.InterfaceSegregationPrinciple.InappropriateISP.Brands;
using ISP.InterfaceSegregationPrinciple.SuitableISP.Brands;

//TODO: Inappropriate LSP - Uygunsuz LSP
Console.WriteLine("**** Inappropriate ISP - Uygunsuz ISP ****");
HPPrinter hpPrinter = new();
hpPrinter.Photocopy();
hpPrinter.Print();

SamsungPrinter samsungPrinter = new();
samsungPrinter.Fax();
//Samsung markalı yazıcıda sadece fax ve yazdırma işlemleri aktif. Ama tanımlı olduğu için fotokopi işlemi yapmaya çalıştığımızda hata alıyoruz.
//samsungPrinter.Photocopy();

Console.WriteLine();

//TODO: Suitable LSP - Uygun LSP
Console.WriteLine("**** Suitable ISP - Uygun ISP ****");
HpPrinterISP hpPrinterISP = new();
hpPrinterISP.Photocopy();
hpPrinterISP.Print();

SamsungPrinterISP samsungPrinterISP = new();
samsungPrinterISP.Fax();
samsungPrinterISP.Print();
//Samsun markalı yazıcıda sadece fax ve yazdırma işlemleri aktif. Tanımlı olan da sadece onlar olduğu için uygun bir tanımlamadır.
//Fotokopi özelliğini istesek bile çağıramıyoruz.
//samsungPrinterISP.Photocopy();

LexmarkPrinterISP lexmarkPrinterISP = new();
lexmarkPrinterISP.Fax();
lexmarkPrinterISP.Print();
lexmarkPrinterISP.Scan();

///<summary>
///ISP örneklerde görüldüğü üzere amaç intefaceleri birbirinde ayırarak dinamik bir şekilde kullanmak geliştirme ve hatayı önlemeyi sağlar.
///Satır 13'teki kullanıma göre satır 20 ve sonrasındaki kullanımlar ISP'ye uygun doğru bir kullanımdır.
///Bu sayede satır 28'deki durumu yaşama ihtimali hiç olmayacaktır.
/// </summary>