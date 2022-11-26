namespace LSP.LiskovSubstitutionPrinciple.InappropriateLSP.Clouds
{
  internal class AWS : CloudServices
  {
    public override void MachineLearning()
    {
      Console.WriteLine("AWS Machine Learning hizmeti veriyor");
    }

    public override void Translate()
    {
      Console.WriteLine("AWS Translate hizmeti veriyor");
    }
  }
}