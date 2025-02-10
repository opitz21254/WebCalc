namespace CalcClasses;

public abstract class CharItem
{
    public string ItemName { get; private set; }
    public bool IsFunction { get; protected set; }
    public bool IsBinaryOperator { get; protected set;}
    public bool IsSpecial { get; protected set;}
    // public decimal Value { get; set; }

    //Constructor
    public CharItem(string itemName)
    {
        ItemName = itemName;
        IsFunction = false;
        IsBinaryOperator = false;
        IsSpecial = false;
        // Value = 0;
    }

    //Makes Item Display String
    public virtual string GetDisplayString()
    {
        return $"{ItemName}";
    }
}
