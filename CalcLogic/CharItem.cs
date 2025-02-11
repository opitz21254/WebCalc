namespace CalcClasses;

public abstract class CharItem
{
    public string DisplayString { get; set; }
    public decimal Value { get; set; }
    public bool IsFunction { get; protected set; }
    public bool IsBinaryOperator { get; protected set; }
    public bool IsSpecial { get; protected set; }

    //Constructor
    public CharItem(string displayString, decimal value = 0)
    {
        DisplayString = displayString;
        Value = value;
        IsFunction = false;
        IsBinaryOperator = false;
        IsSpecial = false;
    }

    //Makes Item Display String
    public virtual string GetDisplayString()
    {
        return $"{DisplayString}";
    }

    public virtual decimal Operate(decimal leftOperand, decimal rightOperand = 0)
    {
        return 0m;
    }
}
