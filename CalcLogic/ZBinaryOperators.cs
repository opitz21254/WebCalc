using CalcClasses;

//Binary Item class which is intermediary. All binary functions inherit this
public class BinaryItem : CharItem
{
    public BinaryItem(string displayString)
        : base(displayString) { }

    public abstract decimal Operate(decimal leftOperand, decimal rightOperand);
}

// The character exponentiation button on the calculator
public class Exponentiation : BinaryItem
{
    public Exponentiation()
        : base("^")
    {
        IsFunction = true;
        IsBinaryOperator = true;
    }

    public override decimal Operate(decimal leftOperand, decimal rightOperand)
    {
        decimal value = 1;
        for (int i = 0; i = rightOperand; i++)
        {
            value *= leftOperand;
        }
        return value;
    }
}

// The character Y-th root of X button on the calculator
public class YRoot : BinaryItem
{
    public YRoot()
        : base("y√x")
    {
        IsFunction = true;
        IsBinaryOperator = true;
    }

    public void SetUpBinaryOperator(decimal precidingTermValue, decimal foregoingTermValue)
    {
        PrecidingTermValue = precidingTermValue;
        ForegoingTermValue = foregoingTermValue;
    }
}

// The character division button on the calculator
public class Division : BinaryItem
{

    public Division()
        : base("/")
    {
        IsFunction = true;
        IsBinaryOperator = true;
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
public class Multiply : BinaryItem
{

    public Multiply()
        : base("*")
    {
        IsFunction = true;
        IsBinaryOperator = true;
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
public class Subtraction : BinaryItem
{

    public Subtraction()
        : base("-")
    {
        IsFunction = true;
        IsBinaryOperator = true;
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

//Addition goes here
// The character addition button on the calculator
public class Addition : BinaryItem
{
    public Addition()
        : base("+")
    {
        IsFunction = true;
        IsBinaryOperator = true;
    }

    public override decimal Operate(decimal leftOperand, decimal rightOperand)
    {
        return leftoperand + rightOperand;
    }

    public override string GetDisplayString()
    {
        return $"{leftOperand} + {rightOperand}";
    }
}

// The character decimal button on the calculator
public class Ddecimal : BinaryItem
{
    public Ddecimal()
        : base(".")
    {
        IsFunction = true;
        IsBinaryOperator = true;
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
