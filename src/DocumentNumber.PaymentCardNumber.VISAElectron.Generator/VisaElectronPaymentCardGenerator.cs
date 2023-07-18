namespace DocumentNumber.PaymentCardNumber.VISAElectron.Generator
{
  using DocumentNumber.PaymentCardNumber.Generator.Common.Generators;

  public class VisaElectronPaymentCardGenerator : CreditCardGeneratorBase
  {
    public VisaElectronPaymentCardGenerator()
    {
      ValidStartNumbers = new[] { "4026", "4508", "4844", "4913", "4917", "417500" };
      ValidDocumentNumberLengths = new[] { 16 };
    }
  }
}
