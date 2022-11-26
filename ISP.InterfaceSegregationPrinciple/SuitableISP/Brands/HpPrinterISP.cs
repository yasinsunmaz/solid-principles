using ISP.InterfaceSegregationPrinciple.SuitableISP.Interfaces;

namespace ISP.InterfaceSegregationPrinciple.SuitableISP.Brands
{
  //TODO: Suitable ISP - Uygun ISP
  public class HpPrinterISP : IFax, IPrint, IPhotocopy, IScan
  {
    public void Fax()
    {
      Console.WriteLine("HP Fax işlemi yapıldı");
    }

    public void Print()
    {
      Console.WriteLine("HP Yazdırma işlemi yapıldı");
    }

    public void Photocopy()
    {
      Console.WriteLine("HP Fotokopi işlemi yapıldı");
    }

    public void Scan()
    {
      Console.WriteLine("HP Tarama işlemi yapıldı");
    }
  }
}