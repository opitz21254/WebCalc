using CalcClasses;

// The character left parenthesis button on the calculator
public class LeftParenthesis : CharItem
{
    public LeftParenthesis()
        : base("(")
    {
        IsSpecial = true;
    }

    public override string GetDisplayString()
    {
        return "(";
    }
}

// The character right parenthesis button on the calculator
public class RightParenthesis : CharItem
{
    public RightParenthesis()
        : base(")")
    {
        IsSpecial = true;
    }

    public override string GetDisplayString()
    {
        return ")";
    }
}

// The Radians Mode button on the calculator
public class Rad : CharItem
{
    public Rad()
        : base("Rad") { }

    public override string GetDisplayString()
    {
        return "";
    }
}

// The Degrees Mode button on the calculator
public class Deg : CharItem
{
    public Deg()
        : base("Deg") { }

    public override string GetDisplayString()
    {
        return "";
    }
}

// The All Clear button on the calculator
public class AllClear : CharItem
{
    public AllClear()
        : base("AC") { }

    public override string GetDisplayString()
    {
        return "";
    }
}

// The Clear Entry button on the calculator
public class ClearEntry : CharItem
{
    public ClearEntry()
        : base("CE") { }

    public override string GetDisplayString()
    {
        return "";
    }
}

// The Random button on the calculator
public class RandomNum : CharItem
{
    public RandomNum()
        : base("Rnd") { }

    public override string GetDisplayString()
    {
        return "Random";
    }
}

// The Answer button on the calculator
public class Answer : CharItem
{
    public Answer()
        : base("Ans") { }

    public override string GetDisplayString()
    {
        return "";
    }
}

// The Equals button on the calculator
public class Equals : CharItem
{
    public Equals()
        : base("Equals") { }

    public override string GetDisplayString()
    {
        return "=";
    }
}
