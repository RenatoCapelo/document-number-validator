﻿using DocumentNumber.PaymentCardNumber.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentNumber.PaymentCardNumber.AmericanExpress.Validator
{
  public sealed class AmericanExpressPaymentCardValidator : IAmericanExpressPaymentCardValidator
  {
    public PaymentCardIssuer IssuerIdentity => throw new NotImplementedException();

    public bool IsSupported(string paymentCardNumber)
    {
      throw new NotImplementedException();
    }

    public bool Validate(string value)
    {
      throw new NotImplementedException();
    }
  }
}
