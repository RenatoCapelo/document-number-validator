﻿namespace DocumentNumber.ValidatorAbstractions
{
  public interface IDocumentNumberValidator
  {
    /// <summary>
    /// Apply the validation algorithm over the value.
    /// </summary>
    /// <param name="value">Value to be validated.</param>
    /// <returns>True, if value verify the algorithm. False, otherwise.</returns>
    bool Validate(string value);
  }
}
