namespace DocumentNumber.PaymentCardNumber.VISA.Generator
{
  using DocumentNumber.PaymentCardNumber.Generator.Common.Generators;

  public class VisaPaymentCardGenerator : CreditCardGeneratorBase
  {
    public VisaPaymentCardGenerator()
    {
      ValidStartNumbers = new[] { "4" };
      ValidDocumentNumberLengths = new[] { 13, 16 };
    }
  }
}
