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
    public CharOne(decimal value = 1)
        : base("1", 1m) { }

    public override string GetDisplayString()
    {
        return $"1";
    }
}

// The character "2" on the calculator
public class CharTwo : CharItem
{
    public CharTwo(decimal value = 2)
        : base("2", 2m) { }

    public override string GetDisplayString()
    {
        return $"2";
    }
}

// The character "3" on the calculator
public class CharThree : CharItem
{
    public CharThree(decimal value = 3)
        : base("3", 3m) { }

    public override string GetDisplayString()
    {
        return $"3";
    }
}

// The character "4" on the calculator
public class CharFour : CharItem
{
    public CharFour(decimal value = 4)
        : base("4", 4m) { }

    public override string GetDisplayString()
    {
        return $"4";
    }
}

// The character "5" on the calculator
public class CharFive : CharItem
{
    public CharFive(decimal value = 5)
        : base("5", 5m) { }

    public override string GetDisplayString()
    {
        return $"5";
    }
}

// The character "6" on the calculator
public class CharSix : CharItem
{
    public CharSix(decimal value = 6)
        : base("6", 6m) { }

    public override string GetDisplayString()
    {
        return $"6";
    }
}

// The character "7" on the calculator
public class CharSeven : CharItem
{
    public CharSeven(decimal value = 7)
        : base("7", 7m) { }

    public override string GetDisplayString()
    {
        return $"7";
    }
}

// The character "8" on the calculator
public class CharEight : CharItem
{
    public CharEight(decimal value = 8)
        : base("8", 8m) { }

    public override string GetDisplayString()
    {
        return $"8";
    }
}

// The character "9" on the calculator
public class CharNine : CharItem
{
    public CharNine(decimal value = 8)
        : base("9", 9m) { }

    public override string GetDisplayString()
    {
        return $"9";
    }
}

public class CharPi : CharItem
{
    public CharPi(decimal value = 3.14m)
        : base("pi", 3.14m) { }

    public override string GetDisplayString()
    {
        return $"π";
    }
}

public class EulersNumber : CharItem
{
    public EulersNumber(decimal value = 2.3m)
        : base("e", 2.3m) { }

    public override string GetDisplayString()
    {
        return $"e";
    }
}
