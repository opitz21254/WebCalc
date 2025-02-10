using CalcClasses;

public class Calculator
{
    public List<CharItem> CharItems { get; private set; }
    public Calculator()
    {
        CharItems = new List<CharItem>();
    }
    //Below are calls for all the private methods for seamingly every function I know.
    // Special Buttons:
    private void setRad()
    {
        CharItems.Add(new Rad());
    }

    private void setDeg()
    {
        CharItems.Add(new Deg());
    }

    // Single Operand Functions:
    private void factorial()
    {
        CharItems.Add(new Factorial());
    }

    private void inverse()
    {
        CharItems.Add(new Inverse());
    }

    private void sine()
    {
        CharItems.Add(new Sine());
    }

    private void arcSine()
    {
        CharItems.Add(new ArcSine());
    }

    private void naturalLog()
    {
        CharItems.Add(new NaturalLog());
    }

    private void cosine()
    {
        CharItems.Add(new Cosine());
    }

    private void arcCosine()
    {
        CharItems.Add(new ArcCosine());
    }

    private void logarithm()
    {
        CharItems.Add(new Logarithm());
    }

    private void tenToTheX()
    {
        CharItems.Add(new TenToTheX());
    }

    private void eToTheX()
    {
        CharItems.Add(new EToTheX());
    }

    private void arcTangent()
    {
        CharItems.Add(new ArcTangent());
    }

    private void squareRoot()
    {
        CharItems.Add(new SquareRoot());
    }

    private void square()
    {
        CharItems.Add(new Square());
    }

    private void tangent()
    {
        CharItems.Add(new Tangent());
    }

    private void percentage()
    {
        CharItems.Add(new Percentage());
    }

    // Class but is it duplicate???
    private void xToTheY()
    {
        CharItems.Add(new XToTheY());
    }

    // Constaints:
    public void charZero()
    {
        CharItems.Add(new CharZero());
    }

    public void charOne()
    {
        CharItems.Add(new CharOne());
    }

    public void charTwo()
    {
        CharItems.Add(new CharTwo());
    }

    public void charThree()
    {
        CharItems.Add(new CharThree());
    }

    public void charFour()
    {
        CharItems.Add(new CharFour());
    }

    public void charFive()
    {
        CharItems.Add(new CharFive());
    }

    public void charSix()
    {
        CharItems.Add(new CharSix());
    }

    public void charSeven()
    {
        CharItems.Add(new CharSeven());
    }

    public void charEight()
    {
        CharItems.Add(new CharEight());
    }

    public void charNine()
    {
        CharItems.Add(new CharNine());
    }

    public void charPi()
    {
        CharItems.Add(new CharPi());
    }

    public void eulersNumber()
    {
        CharItems.Add(new EulersNumber());
    }

    // Special Buttons:
    public void leftParenthesis()
    {
        CharItems.Add(new LeftParenthesis());
    }

    public void rightParenthesis()
    {
        CharItems.Add(new RightParenthesis());
    }

    public void allClear()
    {
        CharItems.Add(new AllClear());
    }

    public void clearEntry()
    {
        CharItems.Add(new ClearEntry());
    }

    public void randomNum()
    {
        CharItems.Add(new RandomNum());
    }

    public void answer()
    {
        CharItems.Add(new Answer());
    }

    public void equals()
    {
        CharItems.Add(new Equals());
    }

    // Binary Operators:
    public void exponentiation()
    {
        CharItems.Add(new Exponentiation());
    }

    public void yRoot()
    {
        CharItems.Add(new YRoot());
    }

    public void division()
    {
        CharItems.Add(new Division());
    }

    public void multiply()
    {
        CharItems.Add(new Multiply());
    }

    public void subtraction()
    {
        CharItems.Add(new Subtraction());
    }

    public void addition()
    {
        CharItems.Add(new Addition());
    }

    public void ddecimal()
    {
        CharItems.Add(new Ddecimal());
    }
}
