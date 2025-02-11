using CalcClasses;

// The factorial "!" button on the calculator
public class Factorial : CharItem
{
    public Factorial()
        : base("!")
    {
        IsFunction = true;
    }

    public override decimal Operate(decimal leftOperand, decimal rightOperand = 0)
    {
        decimal value = 1;
        for (int i = Convert.ToInt32(leftOperand); i > 0; i--)
            {
                value *= i;
            }
        return value;
    }

    public override string GetDisplayString()
    {
        return "!";
    }
}

// The inverse "1/x" button on the calculator
public class Inverse : CharItem
{
    public Inverse()
        : base("1/x")
    {
        IsFunction = true;
    }

    public override string GetDisplayString()
    {
        return "1/x";
    }
}

// The sine "Sin" button on the calculator
public class Sine : CharItem
{
    public Sine()
        : base("Sin")
    {
        IsFunction = true;
    }

    public override string GetDisplayString()
    {
        return "Sin";
    }
}

// The arcsine "ArcSin" button on the calculator
public class ArcSine : CharItem
{
    public ArcSine()
        : base("ArcSin")
    {
        IsFunction = true;
    }

    public override string GetDisplayString()
    {
        return "ArcSin";
    }
}

// The natural logarithm "Ln" button on the calculator
public class NaturalLog : CharItem
{
    public NaturalLog()
        : base("Ln")
    {
        IsFunction = true;
    }

    public override string GetDisplayString()
    {
        return "Ln";
    }
}

// The cosine "Cos" button on the calculator
public class Cosine : CharItem
{
    public Cosine()
        : base("Cos")
    {
        IsFunction = true;
    }

    public override string GetDisplayString()
    {
        return "Cos";
    }
}

// The arccosine "ArcCos" button on the calculator
public class ArcCosine : CharItem
{
    public ArcCosine()
        : base("ArcCos")
    {
        IsFunction = true;
    }

    public override string GetDisplayString()
    {
        return "ArcCos";
    }
}

// The logarithm base 10 "Log" button on the calculator
public class Logarithm : CharItem
{
    public Logarithm()
        : base("Log")
    {
        IsFunction = true;
    }

    public override string GetDisplayString()
    {
        return "Log";
    }
}

// The "10^x" button on the calculator
public class TenToTheX : CharItem
{
    public TenToTheX()
        : base("10^x")
    {
        IsFunction = true;
    }

    public override string GetDisplayString()
    {
        return "10^x";
    }
}

// The "e^x" button on the calculator
public class EToTheX : CharItem
{
    public EToTheX()
        : base("e^x")
    {
        IsFunction = true;
    }

    public override string GetDisplayString()
    {
        return "e^x";
    }
}

// The arctangent "ArcTan" button on the calculator
public class ArcTangent : CharItem
{
    public ArcTangent()
        : base("ArcTan")
    {
        IsFunction = true;
    }

    public override string GetDisplayString()
    {
        return "ArcTan";
    }
}

// The Suare root "√" button on the calculator
public class SquareRoot : CharItem
{
    public SquareRoot()
        : base("√")
    {
        IsFunction = true;
    }

    public override string GetDisplayString()
    {
        return "√";
    }
}

// The Square "^2" button on the calculator
public class Square : CharItem
{
    public Square()
        : base("^2")
    {
        IsFunction = true;
    }

    public override string GetDisplayString()
    {
        return "^2";
    }
}

// The tangent "Tan" button on the calculator
public class Tangent : CharItem
{
    public Tangent()
        : base("Tan")
    {
        IsFunction = true;
    }

    public override string GetDisplayString()
    {
        return "Tan";
    }
}

// The percentage "%" button on the calculator
public class Percentage : CharItem
{
    public Percentage()
        : base("%")
    {
        IsFunction = true;
    }

    public override string GetDisplayString()
    {
        return "%";
    }
}

// XToTheY
public class XToTheY : CharItem
{
    public XToTheY()
        : base("x^y")
    {
        IsFunction = true;
    }

    public override string GetDisplayString()
    {
        return "x^y";
    }
}
