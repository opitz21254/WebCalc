using CalcClasses;

// The character exponentiation button on the calculator
public class Exponentiation : CharItem
{
    public decimal PrecidingTermValue { get; private set; }
    public decimal ForegoingTermValue { get; private set; }

    public Exponentiation()
        : base("^")
    {
        IsFunction = true;
        IsBinaryOperator = true;
        PrecidingTermValue = 0;
        ForegoingTermValue = 0;
    }

    public void SetUpBinaryOperator(decimal precidingTermValue, decimal foregoingTermValue)
    {
        PrecidingTermValue = precidingTermValue;
        ForegoingTermValue = foregoingTermValue;
    }
}

// The character Y-th root of X button on the calculator
public class YRoot : CharItem
{
    public decimal PrecidingTermValue { get; private set; }
    public decimal ForegoingTermValue { get; private set; }

    public YRoot()
        : base("y√x")
    {
        IsFunction = true;
        IsBinaryOperator = true;
        PrecidingTermValue = 0;
        ForegoingTermValue = 0;
    }

    public void SetUpBinaryOperator(decimal precidingTermValue, decimal foregoingTermValue)
    {
        PrecidingTermValue = precidingTermValue;
        ForegoingTermValue = foregoingTermValue;
    }
}

// The character division button on the calculator
public class Division : CharItem
{
    public decimal PrecidingTermValue { get; private set; }
    public decimal ForegoingTermValue { get; private set; }

    public Division()
        : base("/")
    {
        IsFunction = true;
        IsBinaryOperator = true;
        PrecidingTermValue = 0;
        ForegoingTermValue = 0;
    }

    public void SetUpBinaryOperator(decimal precidingTermValue, decimal foregoingTermValue)
    {
        PrecidingTermValue = precidingTermValue;
        ForegoingTermValue = foregoingTermValue;
    }

    public override string GetDisplayString()
    {
        return $"{PrecidingTermValue} / {ForegoingTermValue}";
    }
}

// The character multiply button on the calculator
public class Multiply : CharItem
{
    public decimal PrecidingTermValue { get; private set; }
    public decimal ForegoingTermValue { get; private set; }

    public Multiply()
        : base("*")
    {
        IsFunction = true;
        IsBinaryOperator = true;
        PrecidingTermValue = 0;
        ForegoingTermValue = 0;
    }

    public void SetUpBinaryOperator(decimal precidingTermValue, decimal foregoingTermValue)
    {
        PrecidingTermValue = precidingTermValue;
        ForegoingTermValue = foregoingTermValue;
    }

    public override string GetDisplayString()
    {
        return $"{PrecidingTermValue} * {ForegoingTermValue}";
    }
}

// The character subtraction button on the calculator
public class Subtraction : CharItem
{
    public decimal PrecidingTermValue { get; private set; }
    public decimal ForegoingTermValue { get; private set; }

    public Subtraction()
        : base("-")
    {
        IsFunction = true;
        IsBinaryOperator = true;
        PrecidingTermValue = 0;
        ForegoingTermValue = 0;
    }

    public void SetUpBinaryOperator(decimal precidingTermValue, decimal foregoingTermValue)
    {
        PrecidingTermValue = precidingTermValue;
        ForegoingTermValue = foregoingTermValue;
    }

    public override string GetDisplayString()
    {
        return $"{PrecidingTermValue} - {ForegoingTermValue}";
    }
}

// The character addition button on the calculator
public class Addition : CharItem
{
    public decimal PrecidingTermValue { get; private set; }
    public decimal ForegoingTermValue { get; private set; }

    public Addition()
        : base("+")
    {
        IsFunction = true;
        IsBinaryOperator = true;
        PrecidingTermValue = 0;
        ForegoingTermValue = 0;
    }

    public void SetUpBinaryOperator(decimal precidingTermValue, decimal foregoingTermValue)
    {
        PrecidingTermValue = precidingTermValue;
        ForegoingTermValue = foregoingTermValue;
    }

    public override string GetDisplayString()
    {
        return $"{PrecidingTermValue} + {ForegoingTermValue}";
    }
}

// The character decimal button on the calculator
public class Ddecimal : CharItem
{
    public decimal PrecidingTermValue { get; private set; }
    public decimal ForegoingTermValue { get; private set; }

    public Ddecimal()
        : base(".")
    {
        IsFunction = true;
        IsBinaryOperator = true;
        PrecidingTermValue = 0;
        ForegoingTermValue = 0;
    }

    public void SetUpBinaryOperator(decimal precidingTermValue, decimal foregoingTermValue)
    {
        PrecidingTermValue = precidingTermValue;
        ForegoingTermValue = foregoingTermValue;
    }

    public override string GetDisplayString()
    {
        return $"{PrecidingTermValue} . {ForegoingTermValue}";
    }
}
