using CalcClasses;

public abstract class BinaryItem : CharItem
{
    public BinaryItem(string displayString)
        : base(displayString)
    {
        IsFunction = true;
        IsBinaryOperator = true;
    }

    // // Abstract method to be implemented by specific binary operators
    // public abstract decimal Operate(decimal leftOperand, decimal rightOperand)
    // {
    //     return 0m;
    // }
}

// The character exponentiation button on the calculator
public class Exponentiation : BinaryItem
{
    public Exponentiation()
        : base("^") { }

    public override decimal Operate(decimal leftOperand, decimal rightOperand)
    {
        decimal value = 1;
        for (int i = 0; i < Convert.ToInt32(rightOperand); i++)
        {
            value *= leftOperand;
        }
        return value;
    }

    // public override string GetDisplayString()
    // {
    //     return $"{leftOperand} ^ {rightOperand}";
    // }
}

// The character Y-th root of X button on the calculator
public class YRoot : BinaryItem
{
    public YRoot()
        : base("y√x") { }

    public override decimal Operate(decimal leftOperand, decimal rightOperand)
    {
        return leftOperand + rightOperand;
    }

    // public override string GetDisplayString()
    // {
    //     return $"{leftOperand} / {rightOperand}";
    // }
}

// The character division button on the calculator
public class Division : BinaryItem
{
    public Division()
        : base("/") { }

    public override decimal Operate(decimal leftOperand, decimal rightOperand)
    {
        return leftOperand / rightOperand;
    }

    // public override string GetDisplayString()
    // {
    //     return $"{leftOperand} / {rightOperand}";
    // }
}

// The character multiply button on the calculator
public class Multiply : BinaryItem
{
    public Multiply()
        : base("*") { }

    public override decimal Operate(decimal leftOperand, decimal rightOperand)
    {
        return leftOperand * rightOperand;
    }

    // public override string GetDisplayString()
    // {
    //     return $"{leftOperand} * {rightOperand}";
    // }
}

// The character subtraction button on the calculator
public class Subtraction : BinaryItem
{
    public Subtraction()
        : base("-") { }

    public override decimal Operate(decimal leftOperand, decimal rightOperand)
    {
        return leftOperand - rightOperand;
    }

    // public override string GetDisplayString()
    // {
    //     return $"{leftOperand} - {rightOperand}";
    // }
}

//Addition goes here
// The character addition button on the calculator
public class Addition : BinaryItem
{
    public Addition()
        : base("+") { }

    public override decimal Operate(decimal leftOperand, decimal rightOperand)
    {
        return leftOperand + rightOperand;
    }

    // public override string GetDisplayString()
    // {
    //     return $"{leftOperand} + {rightOperand}";
    // }
}

// The character decimal button on the calculator
public class Ddecimal : BinaryItem
{
    public Ddecimal()
        : base(".") { }

    public override decimal Operate(decimal leftOperand, decimal rightOperand)
    {
        return leftOperand / rightOperand;
    }

    // public override string GetDisplayString()
    // {
    //     return Convert.ToDecimal(leftOperand.ToString() + rightOperand.ToString());
    // }
}
