namespace CalcTests;

public class UnitTest1
{
    [Fact]
    public void CharZero_ShouldAddCharZeroObjectToCharItems()
    {
        // Arrange
        var calculator = new Calculator ();

        // Act
        calculator.charZero();

        //
        Assert.Single(calculator.CharItems);
        Assert.IsType<CharZero>(calculator.CharItems[0]);
    }
}
