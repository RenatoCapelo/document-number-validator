using DocumentNumber.PaymentCardNumber.Common.Enums;

namespace DocumentNumber.PaymentCardNumber.Common.Issuer
{
  public interface IIssuerIdentification
  {
    PaymentCardIssuer SupportedPaymentCardIssuer(string paymentCardNumber);
  }
}