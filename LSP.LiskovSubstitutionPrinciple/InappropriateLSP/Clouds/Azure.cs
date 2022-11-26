namespace LSP.LiskovSubstitutionPrinciple.InappropriateLSP.Clouds
{
  internal class Azure : CloudServices
  {
    public override void MachineLearning()
    {
      Console.WriteLine("Azure Machine Learning hizmeti veriyor");
    }

    public override void Translate()
    {
      throw new NotImplementedException();
    }
  }
}