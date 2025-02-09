using CalcClasses;

// The character exponentiation button on the calculator
public class Exponentiation : CharItem
{
    public (decimal PrecidingTermValue, string Operator, decimal ForegoingTermValue) DisplaySet
    {
        get;
        private set;
    }

    public Exponentiation()
        : base("^")
    {
        DisplaySet = (0m, "^", 0m);
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
    public (decimal PrecidingTermValue, string Operator, decimal ForegoingTermValue) DisplaySet
    {
        get;
        private set;
    }

    public YRoot()
        : base("y√x")
    {
        DisplaySet = (0m, "y√x", 0m);
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
    public (decimal PrecidingTermValue, string Operator, decimal ForegoingTermValue) DisplaySet
    {
        get;
        private set;
    }

    public Division()
        : base("/")
    {
        DisplaySet = (0m, "/", 0m);
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
    public (decimal PrecidingTermValue, string Operator, decimal ForegoingTermValue) DisplaySet
    {
        get;
        private set;
    }

    public Multiply()
        : base("*")
    {
        DisplaySet = (0m, "*", 0m);
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
    public (decimal PrecidingTermValue, string Operator, decimal ForegoingTermValue) DisplaySet
    {
        get;
        private set;
    }

    public Subtraction()
        : base("-")
    {
        DisplaySet = (0m, "-", 0m);
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
    public (decimal PrecidingTermValue, string Operator, decimal ForegoingTermValue) DisplaySet
    {
        get;
        private set;
    }

    public Addition()
        : base("+")
    {
        DisplaySet = (0m, "+", 0m);
        IsFunction = true;
        IsBinaryOperator = true;
    }

    public override string GetDisplayString()
    {
        return $"{DisplaySet.PrecidingTermValue} {DisplaySet.Operator} {DisplaySet.ForegoingTermValue}";
    }
}

// The character decimal button on the calculator
public class Ddecimal : CharItem
{
    public (decimal PrecidingTermValue, string Operator, decimal ForegoingTermValue) DisplaySet
    {
        get;
        private set;
    }

    public Ddecimal()
        : base("+")
    {
        DisplaySet = (0m, ".", 0m);
        IsFunction = true;
        IsBinaryOperator = true;
    }

    public override string GetDisplayString()
    {
        return $"{DisplaySet.PrecidingTermValue} {DisplaySet.Operator} {DisplaySet.ForegoingTermValue}";
    }
}