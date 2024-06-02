Console.WriteLine("Provide total: ");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscount(userInput);
Console.WriteLine($"Your discount is: {discount}%");

double newTotal = CalculateNewTotal(userInput, discount);
Console.WriteLine($"Your updated total with {discount}%: {newTotal}");

static double CalculateDiscount(int total)
{
    if (total < 10)
    {
        return 1;
    }
    else if (total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}

Console.WriteLine("Type 1 to convert Fahrenheit to Celsius");
Console.WriteLine("Type 2 to convert Celsius to Fahrenheit");
int choice = Int32.Parse(Console.ReadLine());

if (choice == 1)
{
    Console.Write("Enter temperature: ");
    int fahrenheit = Int32.Parse(Console.ReadLine());
    ConvertToCelsius(fahrenheit);
}
else if (choice == 2)
{
    Console.Write("Enter temperature: ");
    int celsius = Int32.Parse(Console.ReadLine());
    ConvertToFahrenheit(celsius);
}
else
{
    Console.WriteLine("Invalid choice. Please run the program again.");
}


static void ConvertToCelsius(int fahrenheit)
{
    int celsius = (fahrenheit - 32) * 5 / 9;
    Console.WriteLine(celsius);
}

static void ConvertToFahrenheit(int celsius)
{
    int fahrenheit = (celsius * 9) / 5 + 32;
    Console.WriteLine(fahrenheit);
}