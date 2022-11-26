namespace LSP.LiskovSubstitutionPrinciple.InappropriateLSP
{
  //TODO: Suitable LSP - Uygun LSP
  internal abstract class CloudServicesLSP
  {
    //Eğer MachineLearning özelliği de bazılarında olmayacak olursa onu da interface ile kullanmak doğru olacaktır.
    public abstract void MachineLearning();
  }
}