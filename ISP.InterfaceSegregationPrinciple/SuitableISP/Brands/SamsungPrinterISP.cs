using ISP.InterfaceSegregationPrinciple.SuitableISP.Interfaces;

namespace ISP.InterfaceSegregationPrinciple.SuitableISP.Brands
{
  //TODO: Suitable ISP - Uygun ISP
  public class SamsungPrinterISP : IFax, IPrint
  {
    public void Fax()
    {
      Console.WriteLine("Samsung Fax işlemi yapıldı");
    }

    public void Print()
    {
      Console.WriteLine("Samsung Yazdırma işlemi yapıldı");
    }
  }
}