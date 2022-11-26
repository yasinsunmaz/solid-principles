namespace LSP.LiskovSubstitutionPrinciple.InappropriateLSP.Clouds
{
  internal class AzureLSP : CloudServicesLSP
  {
    public override void MachineLearning()
    {
      Console.WriteLine("Azure Machine Learning hizmeti veriyor");
    }
  }
}