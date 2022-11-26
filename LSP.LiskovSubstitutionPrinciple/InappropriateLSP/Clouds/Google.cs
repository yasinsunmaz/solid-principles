namespace LSP.LiskovSubstitutionPrinciple.InappropriateLSP.Clouds
{
  internal class Google : CloudServices
  {
    public override void MachineLearning()
    {
      Console.WriteLine("Google Machine Learning hizmeti veriyor");
    }

    public override void Translate()
    {
      Console.WriteLine("Google Translate hizmeti veriyor");
    }
  }
}