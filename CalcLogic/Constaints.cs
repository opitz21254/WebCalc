using CalcClasses;

// The character "0" on the calculator
public class CharZero : CharItem
{
    public CharZero(decimal value = 0) //optional paramiter. Defaults to zero
        : base("0", value) { }

    public override string GetDisplayString()
    {
        return $"0";
    }
}

// The character "1" on the calculator
public class CharOne : CharItem
{
    public decimal Value { get; set; } = 1;

    public CharOne()
        : base("1")
    {
        Value = 1;
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

    public CharTwo()
        : base("2")
    {
        Value = 2;
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

    public CharThree()
        : base("3")
    {
        Value = 3;
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

    public CharFour()
        : base("4")
    {
        Value = 4;
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

    public CharFive()
        : base("5")
    {
        Value = 5;
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

    public CharSix()
        : base("6")
    {
        Value = 6;
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

    public CharSeven()
        : base("7")
    {
        Value = 7;
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

    public CharEight()
        : base("8")
    {
        Value = 8;
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

    public CharNine()
        : base("9")
    {
        Value = 9;
    }

    public override string GetDisplayString()
    {
        return $"9";
    }
}

public class CharPi : CharItem
{
    public decimal Value { get; set; } = 3.14159M;

    public CharPi()
        : base("pi")
    {
        Value = 3.14159M;
    }

    public override string GetDisplayString()
    {
        return $"π";
    }
}

public class EulersNumber : CharItem
{
    public decimal Value { get; set; } = 2.71828M;

    public EulersNumber()
        : base("e")
    {
        Value = 2.71828M;
    }

    public override string GetDisplayString()
    {
        return $"e";
    }
}
