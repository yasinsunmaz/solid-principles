using ISP.InterfaceSegregationPrinciple.InappropriateISP.Interfaces;

namespace ISP.InterfaceSegregationPrinciple.InappropriateISP.Brands
{
  public class HPPrinter : IPrinter
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