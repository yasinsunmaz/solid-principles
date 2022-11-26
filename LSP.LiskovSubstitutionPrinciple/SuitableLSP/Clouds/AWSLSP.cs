using LSP.LiskovSubstitutionPrinciple.SuitableLSP.Interfaces;

namespace LSP.LiskovSubstitutionPrinciple.InappropriateLSP.Clouds
{
  internal class AWSLSP : CloudServicesLSP, ITranslatable
  {
    public override void MachineLearning()
    {
      Console.WriteLine("AWS Machine Learning hizmeti veriyor");
    }

    public void Translate()
    {
      Console.WriteLine("AWS Translate hizmeti veriyor");
    }
  }
}