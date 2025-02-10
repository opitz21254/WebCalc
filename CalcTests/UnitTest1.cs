namespace CalcTests;

public class UnitTest1
{
    [Fact]
    public void CharZero_ShouldAddCharZeroObjectToCharItems()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        calculator.charZero();

        //
        Assert.Single(calculator.CharItems);
        Assert.IsType<CharZero>(calculator.CharItems[0]);
    }

    [Fact]
    public void Addition_ShouldAddAdditionObjectToCharItems()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        calculator.addition();

        // Assert
        Assert.Single(calculator.CharItems);
        Assert.IsType<Addition>(calculator.CharItems[0]);
    }

    [Fact]
    public void Evaluate_CharFour_ShouldBeStoredWithCorrectValue()
    {
        // Arrange
        var calculator = new Calculator();
        calculator.charFour();

        // Act
        var result = calculator.CharItems[0] as CharFour;

        // Assert
        Assert.Equal(4m, result?.Value); // Check that the value is 4
    }

    [Fact]
    public void Multiply_ShouldAddMultiplyObjectToCharItems()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        calculator.multiply();

        // Assert
        Assert.Single(calculator.CharItems);
        Assert.IsType<Multiply>(calculator.CharItems[0]);
    }

    //Tests Part II
    //Challenge

    // Test for simple addition
    [Fact]
    public void Evaluate_SimpleAddition_ShouldReturnCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();
        calculator.charThree();
        calculator.addition();
        calculator.charFive();
        calculator.equals();

        // Act
        var result = calculator.CharItems[0] as CharEight;

        // Assert
        Assert.Equal(8m, result?.Value); // 3 + 5 = 8
    }

    // Test for simple subtraction
    [Fact]
    public void Evaluate_SimpleSubtraction_ShouldReturnCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();
        calculator.charNine();
        calculator.subtraction();
        calculator.charFour();
        calculator.equals();

        // Act
        var result = calculator.CharItems[0] as CharFive;

        // Assert
        Assert.Equal(5m, result?.Value); // 9 - 4 = 5
    }

    // Test for simple multiplication
    [Fact]
    public void Evaluate_SimpleMultiplication_ShouldReturnCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();
        calculator.charTwo();
        calculator.multiply();
        calculator.charSix();
        calculator.equals();

        // Act
        var result = calculator.CharItems[0] as CharOne;

        // Assert
        Assert.Equal(12m, result?.Value); // 2 * 6 = 12
    }

    // Test for simple division
    [Fact]
    public void Evaluate_SimpleDivision_ShouldReturnCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();
        calculator.charEight();
        calculator.division();
        calculator.charTwo();
        calculator.equals();

        // Act
        var result = calculator.CharItems[0] as CharFour;

        // Assert
        Assert.Equal(4m, result?.Value); // 8 / 2 = 4
    }

    // Test for exponentiation
    [Fact]
    public void Evaluate_Exponentiation_ShouldReturnCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();
        calculator.charTwo();
        calculator.exponentiation();
        calculator.charThree();
        calculator.equals();

        // Act
        var result = calculator.CharItems[0] as CharEight;

        // Assert
        Assert.Equal(8m, result?.Value); // 2^3 = 8
    }

    // Test for square root
    [Fact]
    public void Evaluate_SquareRoot_ShouldReturnCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();
        calculator.charNine();
        calculator.squareRoot();
        calculator.equals();

        // Act
        var result = calculator.CharItems[0] as CharThree;

        // Assert
        Assert.Equal(3m, result?.Value); // sqrt(9) = 3
    }

    // Test for percentage
    [Fact]
    public void Evaluate_Percentage_ShouldReturnCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();
        calculator.charNine();
        calculator.percentage();
        calculator.equals();

        // Act
        var result = calculator.CharItems[0] as CharZero;

        // Assert
        Assert.Equal(0.5m, result?.Value); // 50% = 0.5
    }

    // Test for factorial
    [Fact]
    public void Evaluate_Factorial_ShouldReturnCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();
        calculator.charFour();
        calculator.factorial();
        calculator.equals();

        // Act
        var result = calculator.CharItems[0] as CharTwo;

        // Assert
        Assert.Equal(24m, result?.Value); // 4! = 24
    }

    // Test for sine function
    [Fact]
    public void Evaluate_Sine_ShouldReturnCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();
        calculator.charZero();
        calculator.sine();
        calculator.equals();

        // Act
        var result = calculator.CharItems[0] as CharZero;

        // Assert
        Assert.Equal(0m, result?.Value); // sin(0) = 0
    }

    // Test for cosine function
    [Fact]
    public void Evaluate_Cosine_ShouldReturnCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();
        calculator.charZero();
        calculator.cosine();
        calculator.equals();

        // Act
        var result = calculator.CharItems[0] as CharOne;

        // Assert
        Assert.Equal(1m, result?.Value); // cos(0) = 1
    }

    // Test for tangent function
    [Fact]
    public void Evaluate_Tangent_ShouldReturnCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();
        calculator.charZero();
        calculator.tangent();
        calculator.equals();

        // Act
        var result = calculator.CharItems[0] as CharZero;

        // Assert
        Assert.Equal(0m, result?.Value); // tan(0) = 0
    }

    // Test for logarithm function
    [Fact]
    public void Evaluate_Logarithm_ShouldReturnCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();
        calculator.charOne();
        calculator.charZero();
        calculator.logarithm();
        calculator.equals();

        // Act
        var result = calculator.CharItems[0] as CharZero;

        // Assert
        Assert.Equal(1m, result?.Value); // log10(10) = 1
    }
}
