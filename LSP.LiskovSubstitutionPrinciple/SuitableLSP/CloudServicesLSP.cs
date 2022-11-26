namespace LSP.LiskovSubstitutionPrinciple.InappropriateLSP
{
  internal abstract class CloudServicesLSP
  {
    //Eğer MachineLearning özelliği de bazılarında olmayacak olursa onu da interface ile kullanmak doğru olacaktır.
    public abstract void MachineLearning();
  }
}