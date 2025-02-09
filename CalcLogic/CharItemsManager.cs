using CalcClasses;

public class CharItemsManager
{
   //StoreItem is actually more like an ItemManager class
    List<CharItem> CharItems { get; set; } = new List<CharItem>(); //Initializes an empty "Problem Entry"
    public void RunProgram()
    {
        CharItems.Add(new CharZero(0m));
        CharItems.Add(new Factorial());
        CharItem.Add(new LeftParenthases());
    }

    private decimal CalculateTotal()
    {
        return CharItems.Count()
    }
}