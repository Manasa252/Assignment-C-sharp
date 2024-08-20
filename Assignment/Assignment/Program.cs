
using Assignment;

class Pro
{
    public static void Main()
    {
        CurrencyConverter[] cc = new CurrencyConverter[4];
        cc[0] = new CurrencyConverter();
        cc[1] = new CurrencyConverter("EUR", "USD", 1.11);
        cc[2] = new CurrencyConverter();
        cc[3] = new CurrencyConverter("USD", "EUR", 1.11);

        Console.WriteLine(cc[0].ConvertAmount(100));
        Console.WriteLine(cc[1].ConvertAmount(100));
        Console.WriteLine(cc[2].ConvertAmount(100.2, 45.6));
        Console.WriteLine(cc[3].ConvertAmount(104.8, 67.89));

        VendingMachine vendingMachine = new VendingMachine();
        Product snack = new Snack();
        Product beverage = new Beverage();
        vendingMachine.SelectProduct(snack);
        vendingMachine.SelectProduct(beverage);
    }
}