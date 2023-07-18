namespace DocumentNumber.Portugal.CitizenCard.Generator.Tests
{
  using DocumentNumber.Portugal.CitizenCard.Generator;
  using DocumentNumber.Portugal.CitizenCard.Validator;
  using Shouldly;
  using Xunit;
  public class CitizenCardNumberGeneratorTests
  {
    [Fact(DisplayName = "For Given CC id '316880728ZV', the checkDigit must be '3'")]
    public void Test1()
    {
      // Arrange
      CitizenCardNumberGenerator numberGenerator = new CitizenCardNumberGenerator();
      string givenCCNumber = "316880728ZV";
      int expectedCheckDigit = 3;

      // Act
      int calculatedCheckDigit = numberGenerator.CalculateCheckDigit(givenCCNumber);

      // Assert
      calculatedCheckDigit.ShouldBe(expectedCheckDigit);
    }
  }
}