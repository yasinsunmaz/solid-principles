using ISP.InterfaceSegregationPrinciple.InappropriateISP.Interfaces;

namespace ISP.InterfaceSegregationPrinciple.InappropriateISP.Brands
{
  public class SamsungPrinter : IPrinter
  {
    public void Fax()
    {
      Console.WriteLine("Samsung Fax işlemi yapıldı");
    }

    public void Print()
    {
      Console.WriteLine("Samsung Yazdırma işlemi yapıldı");
    }

    public void Photocopy()
    {
      throw new NotSupportedException();
    }

    public void Scan()
    {
      throw new NotSupportedException();
    }
  }
}