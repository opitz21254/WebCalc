using CalcClasses;

// The character "0" on the calculator
public class CharZero : CharItem
{
    public decimal Value { get; set; } = 0;
    public CharZero(decimal value)
        : base("0")
    {
        Value = value;
    }

    public override string GetDisplayString()
    {
        return $"0";
    }
}

// The character "1" on the calculator
public class CharOne : CharItem
{
    public decimal Value { get; set; } = 1;
    public CharOne(decimal value)
        : base("1")
    {
        Value = value;
    }

    public override string GetDisplayString()
    {
        return $"1";
    }
}

// The character "2" on the calculator
public class CharTwo : CharItem
{
    public decimal Value { get; set; } = 2;
    public CharTwo(decimal value)
        : base("2")
    {
        Value = value;
    }

    public override string GetDisplayString()
    {
        return $"2";
    }
}

// The character "3" on the calculator
public class CharThree : CharItem
{
    public decimal Value { get; set; } = 3;
    public CharThree(decimal value)
        : base("3")
    {
        Value = value;
    }

    public override string GetDisplayString()
    {
        return $"3";
    }
}

// The character "4" on the calculator
public class CharFour : CharItem
{
    public decimal Value { get; set; } = 4;
    public CharFour(decimal value)
        : base("4")
    {
        Value = value;
    }

    public override string GetDisplayString()
    {
        return $"4";
    }
}

// The character "5" on the calculator
public class CharFive : CharItem
{
    public decimal Value { get; set; } = 5;
    public CharFive(decimal value)
        : base("5")
    {
        Value = value;
    }

    public override string GetDisplayString()
    {
        return $"5";
    }
}

// The character "6" on the calculator
public class CharSix : CharItem
{
    public decimal Value { get; set; } = 6;
    public CharSix(decimal value)
        : base("6")
    {
        Value = value;
    }

    public override string GetDisplayString()
    {
        return $"6";
    }
}

// The character "7" on the calculator
public class CharSeven : CharItem
{
    public decimal Value { get; set; } = 7;
    public CharSeven(decimal value)
        : base("7")
    {
        Value = value;
    }

    public override string GetDisplayString()
    {
        return $"7";
    }
}

// The character "8" on the calculator
public class CharEight : CharItem
{
    public decimal Value { get; set; } = 8;
    public CharEight(decimal value)
        : base("8")
    {
        Value = value;
    }

    public override string GetDisplayString()
    {
        return $"8";
    }
}

// The character "9" on the calculator
public class CharNine : CharItem
{
    public decimal Value { get; set; } = 9;
    public CharNine(decimal value)
        : base("9")
    {
        Value = value;
    }

    public override string GetDisplayString()
    {
        return $"9";
    }
}
