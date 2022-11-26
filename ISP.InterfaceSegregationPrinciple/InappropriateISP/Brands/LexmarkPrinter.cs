using ISP.InterfaceSegregationPrinciple.InappropriateISP.Interfaces;

namespace ISP.InterfaceSegregationPrinciple.InappropriateISP.Brands
{
  public class LexmarkPrinter : IPrinter
  {
    public void Fax()
    {
      Console.WriteLine("Lexmark Fax işlemi yapıldı");
    }

    public void Print()
    {
      Console.WriteLine("Lexmark Yazdırma işlemi yapıldı");
    }

    public void Photocopy()
    {
      throw new NotSupportedException();
    }

    public void Scan()
    {
      Console.WriteLine("Lexmark Tarama işlemi yapıldı");
    }
  }
}