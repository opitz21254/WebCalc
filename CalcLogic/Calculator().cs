using CalcClasses;

public class Calculator
{
    public List<CharItem> CharItems { get; private set; }

    public Calculator()
    {
        CharItems = new List<CharItem>();
    }

    //Below are calls for all the public methods for seamingly every function I know.
    // Special Buttons:
    public void equals()
    {
        for (int i = 0; i < CharItems.Count; i++)
        {
            if (CharItems[i].IsBinaryOperator)
            {
                // Ensure valid indices for operands
                if (i >= 1 && i < CharItems.Count - 1)
                {
                    if (CharItems[i].IsFunction)
                    {
                        var leftOperand = CharItems[i - 1].Value;
                        var rightOperand = CharItems[i + 1].Value;
                        var result = leftOperand + rightOperand;
                        CharItems.RemoveRange(i - 1, 3); //Starting index and count
                        // int positionStart = i - 1;
                        CharItems.Insert(0, new CharZero(result));
                    }
                }
            }
        }
    }

    public void setRad()
    {
        CharItems.Add(new Rad());
    }

    public void setDeg()
    {
        CharItems.Add(new Deg());
    }

    // Single Operand Functions:
    public void factorial()
    {
        CharItems.Add(new Factorial());
    }

    public void inverse()
    {
        CharItems.Add(new Inverse());
    }

    public void sine()
    {
        CharItems.Add(new Sine());
    }

    public void arcSine()
    {
        CharItems.Add(new ArcSine());
    }

    public void naturalLog()
    {
        CharItems.Add(new NaturalLog());
    }

    public void cosine()
    {
        CharItems.Add(new Cosine());
    }

    public void arcCosine()
    {
        CharItems.Add(new ArcCosine());
    }

    public void logarithm()
    {
        CharItems.Add(new Logarithm());
    }

    public void tenToTheX()
    {
        CharItems.Add(new TenToTheX());
    }

    public void eToTheX()
    {
        CharItems.Add(new EToTheX());
    }

    public void arcTangent()
    {
        CharItems.Add(new ArcTangent());
    }

    public void squareRoot()
    {
        CharItems.Add(new SquareRoot());
    }

    public void tangent()
    {
        CharItems.Add(new Tangent());
    }

    public void percentage()
    {
        CharItems.Add(new Percentage());
    }

    // Class but is it duplicate???
    public void xToTheY()
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
