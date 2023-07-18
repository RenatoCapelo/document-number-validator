namespace DocumentNumber.PaymentCardNumber.Maestro.Generator
{
  using DocumentNumber.PaymentCardNumber.Generator.Common.Generators;

  public class MaestroPaymentCardGenerator : CreditCardGeneratorBase
  {
    public MaestroPaymentCardGenerator()
    {
      ValidStartNumbers = new[] { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };
      ValidDocumentNumberLengths = new[] { 12, 13, 14, 15, 16, 17, 18, 19 };
    }
  }
}
