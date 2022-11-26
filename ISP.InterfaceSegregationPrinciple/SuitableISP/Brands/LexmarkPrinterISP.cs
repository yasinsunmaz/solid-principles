using ISP.InterfaceSegregationPrinciple.SuitableISP.Interfaces;

namespace ISP.InterfaceSegregationPrinciple.SuitableISP.Brands
{
  //TODO: Suitable ISP - Uygun ISP
  public class LexmarkPrinterISP : IFax, IPrint
  {
    public void Fax()
    {
      Console.WriteLine("Lexmark Fax işlemi yapıldı");
    }

    public void Print()
    {
      Console.WriteLine("Lexmark Yazdırma işlemi yapıldı");
    }

    public void Scan()
    {
      Console.WriteLine("Lexmark Tarama işlemi yapıldı");
    }
  }
}