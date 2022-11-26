using LSP.LiskovSubstitutionPrinciple.InappropriateLSP;
using LSP.LiskovSubstitutionPrinciple.InappropriateLSP.Clouds;
using LSP.LiskovSubstitutionPrinciple.SuitableLSP.Interfaces;

//TODO: Inappropriate LSP - Uygunsuz LSP
Console.WriteLine("**** Inappropriate LSP - Uygunsuz LSP ****");
CloudServices cloudServices = new AWS();
Console.WriteLine("*** AWS Hizmeti ***");
cloudServices.MachineLearning();
cloudServices.Translate();

Console.WriteLine("*** Google Hizmeti ***");
cloudServices = new Google();
cloudServices.MachineLearning();
cloudServices.Translate();

Console.WriteLine("*** Azure Hizmeti ***");
cloudServices = new Azure();
cloudServices.MachineLearning();

//Azure Translate hizmeti vermediği için bu adımda program hata verecektir!
//cloudServices.Translate();

Console.WriteLine();

//TODO: Suitable LSP - Uygun LSP
Console.WriteLine("**** Suitable LSP - Uygun LSP ****");
CloudServicesLSP cloudServicesLSP = new AWSLSP();
Console.WriteLine("*** AWS Hizmeti ***");
cloudServicesLSP.MachineLearning();
(cloudServicesLSP as ITranslatable)?.Translate();

Console.WriteLine("*** Google Hizmeti ***");
cloudServicesLSP = new GoogleLSP();
cloudServicesLSP.MachineLearning();
(cloudServicesLSP as ITranslatable)?.Translate();

Console.WriteLine("*** Azure Hizmeti ***");
cloudServicesLSP = new AzureLSP();
cloudServicesLSP.MachineLearning();
(cloudServicesLSP as ITranslatable)?.Translate();

///<summary>
///LSP örneklerde görüldüğü üzere amaç ortak işlevleri yerine getiren durumlar dışında farklı bir durumun eklenmesi ile
///mevcut yapıyı bozmadan devam edebilecek şekilde kurguyu devam ettirmektir.
///Satır 22'deki kullanıma göre satır 41'deki kullanım LSP'ye uygun doğru bir kullanımdır.
/// </summary>