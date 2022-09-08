public class Program
{
    public static string Name()
    {
        Console.Write("Please input Name: ");
        return Console.ReadLine();
    }
    public static string NumberID()
    {
        Console.Write("Input Number ID : ");
        return Console.ReadLine();
    }
    public static string OwnerName()
    {
        Console.Write("Please input Owner name : ");
        return Console.ReadLine();
    }
    public static string RegisteredValue()
    {
        Console.Write("Please input Registered value : ");
        return Console.ReadLine();
    }
    
    public static void Main(string[] args)
    {
        string name = Name();
        string id = NumberID();
        string owner = OwnerName();
        string value = RegisteredValue();

        Console.WriteLine("------------Shop Information------------");
        Console.WriteLine("Name: {0}",name);
        Console.WriteLine("Number: {0}",id);
        Console.WriteLine("Owner name: {0}",owner);
        Console.WriteLine("Regitered value: {0}",value);
        Console.WriteLine("----------------------------------------");
        Money moneycalc = new Money();
        moneycalc.MonGen();
    }
}
