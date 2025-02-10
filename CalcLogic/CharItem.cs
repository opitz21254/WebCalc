﻿namespace CalcClasses;

public abstract class CharItem
{
    public string DisplayString { get; private set; }
    public bool IsFunction { get; protected set; }
    public bool IsBinaryOperator { get; protected set; }
    public bool IsSpecial { get; protected set; }
    public decimal Value { get; set; }

    // public decimal Value { get; set; }

    //Constructor
    public CharItem(string displayString, decimal value = 0)
    {
        DisplayString = displayString;
        IsFunction = false;
        IsBinaryOperator = false;
        IsSpecial = false;
        Value = value;
        // Value = 0;
    }

    //Makes Item Display String
    public virtual string GetDisplayString()
    {
        return $"{DisplayString}";
    }
}
