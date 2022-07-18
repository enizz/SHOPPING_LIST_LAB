decimal cartTotal = 0.00m;
ConsoleKeyInfo key;
var cartItems = new List<KeyValuePair<string, decimal>>();
string input = "";

Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
menu.Add("item1", 3.50m);
menu.Add("item2", 0.99m);
menu.Add("item3", 5.99m);
menu.Add("item4", 9.99m);
menu.Add("item5", 2.55m);
menu.Add("item6", 1.99m);
menu.Add("item7", 0.75m);
menu.Add("item8", 0.25m);

Console.WriteLine("Here is what we have on our menu:\n");
do
{
    DisplayMenu();
    Console.WriteLine("\nEnter your order\n");
    input = Console.ReadLine();
    Order(input);
    Console.WriteLine("\nPress ENTER to add to your order or any other key to checkout");
    key = Console.ReadKey();
}
while(key.Key == ConsoleKey.Enter);
Checkout();

// functions

void Order(string input2)
{
    while (menu.ContainsKey(input) != true)
    {
        Console.WriteLine("\nSorry, that item is not on our menu. Please try again.\n");
        DisplayMenu();
        input = Console.ReadLine();
    }

    Console.WriteLine("\nAdding " + input + " to your cart at $" + menu[input]);
    cartItems.Add(new KeyValuePair<string, decimal>(input, menu[input]));    
}
void DisplayMenu()
{
    foreach (KeyValuePair<string, decimal> item in menu)
    {
        Console.WriteLine("{0}: $ {1}", item.Key, item.Value);
    }
}
void Checkout()
{
    Console.WriteLine("\nThanks for your order!\n");
    Console.WriteLine("\nHere is your receipt:");
    cartItems = cartItems.OrderBy(kvp => kvp.Value).ToList();//ec
    foreach (var x in cartItems)
    {
        Console.WriteLine(x);
        cartTotal += x.Value;
    }
    Console.WriteLine("Your total is: $" + cartTotal);
    Console.WriteLine("Cheapest item was: " + cartItems.First());//ec
    Console.WriteLine("Most expensive item was: " + cartItems.Last());//ec
}