namespace App;

public static class Program
{
    static bool IsDigit(char c)
    {
        return c >= '0' && c <= '9';
    }
    public static void Main()
    {
        for (int i = 0; i < 200; i++)
        {
            Console.WriteLine($"{i} : {Prices.GetCurrencyAlias(i, false, false)}");
        }
        
    }
}