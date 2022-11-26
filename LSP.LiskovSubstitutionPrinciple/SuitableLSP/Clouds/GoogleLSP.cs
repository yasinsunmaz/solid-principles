using LSP.LiskovSubstitutionPrinciple.SuitableLSP.Interfaces;

namespace LSP.LiskovSubstitutionPrinciple.InappropriateLSP.Clouds
{
  internal class GoogleLSP : CloudServicesLSP, ITranslatable
  {
    public override void MachineLearning()
    {
      Console.WriteLine("Google Machine Learning hizmeti veriyor");
    }

    public void Translate()
    {
      Console.WriteLine("Google Translate hizmeti veriyor");
    }
  }
}