using CalcClasses;

// The character exponentiation button on the calculator
public class Exponentiation : CharItem
{
    public (decimal PrecidingTermValue, string Operator, decimal ForegoingTermValue) DisplaySet { get; private set; }

    public Exponentiation(decimal precidingTermValue, decimal foregoingTermValue)
        : base("^")
    {
        DisplaySet = (precidingTermValue, "^", foregoingTermValue);
        IsFunction = true;
        IsBinaryOperator = true;
    }

    public override string GetDisplayString()
    {
        return $"{DisplaySet.PrecidingTermValue} {DisplaySet.Operator} {DisplaySet.ForegoingTermValue}";
    }
}

// The character Y-th root of X button on the calculator
public class YRoot : CharItem
{
    public (decimal PrecidingTermValue, string Operator, decimal ForegoingTermValue) DisplaySet { get; private set; }

    public YRoot(decimal precidingTermValue, decimal foregoingTermValue)
        : base("y√x")
    {
        DisplaySet = (precidingTermValue, "y√x", foregoingTermValue);
        IsFunction = true;
        IsBinaryOperator = true;
    }

    public override string GetDisplayString()
    {
        return $"{DisplaySet.PrecidingTermValue} {DisplaySet.Operator} {DisplaySet.ForegoingTermValue}";
    }
}

// The character division button on the calculator
public class Division : CharItem
{
    public (decimal PrecidingTermValue, string Operator, decimal ForegoingTermValue) DisplaySet { get; private set; }

    public Division(decimal precidingTermValue, decimal foregoingTermValue)
        : base("/")
    {
        DisplaySet = (precidingTermValue, "/", foregoingTermValue);
        IsFunction = true;
        IsBinaryOperator = true;
    }

    public override string GetDisplayString()
    {
        return $"{DisplaySet.PrecidingTermValue} {DisplaySet.Operator} {DisplaySet.ForegoingTermValue}";
    }
}

// The character multiply button on the calculator
public class Multiply : CharItem
{
    public (decimal PrecidingTermValue, string Operator, decimal ForegoingTermValue) DisplaySet { get; private set; }

    public Multiply(decimal precidingTermValue, decimal foregoingTermValue)
        : base("*")
    {
        DisplaySet = (precidingTermValue, "*", foregoingTermValue);
        IsFunction = true;
        IsBinaryOperator = true;
    }

    public override string GetDisplayString()
    {
        return $"{DisplaySet.PrecidingTermValue} {DisplaySet.Operator} {DisplaySet.ForegoingTermValue}";
    }
}

// The character subtraction button on the calculator
public class Subtraction : CharItem
{
    public (decimal PrecidingTermValue, string Operator, decimal ForegoingTermValue) DisplaySet { get; private set; }

    public Subtraction(decimal precidingTermValue, decimal foregoingTermValue)
        : base("-")
    {
        DisplaySet = (precidingTermValue, "-", foregoingTermValue);
        IsFunction = true;
        IsBinaryOperator = true;
    }

    public override string GetDisplayString()
    {
        return $"{DisplaySet.PrecidingTermValue} {DisplaySet.Operator} {DisplaySet.ForegoingTermValue}";
    }
}

// The character addition button on the calculator
public class Addition : CharItem
{
    public (decimal PrecidingTermValue, string Operator, decimal ForegoingTermValue) DisplaySet { get; private set; }

    public Addition(decimal precidingTermValue, decimal foregoingTermValue)
        : base("+")
    {
        DisplaySet = (precidingTermValue, "+", foregoingTermValue);
        IsFunction = true;
        IsBinaryOperator = true;
    }

    public override string GetDisplayString()
    {
        return $"{DisplaySet.PrecidingTermValue} {DisplaySet.Operator} {DisplaySet.ForegoingTermValue}";
    }
}

