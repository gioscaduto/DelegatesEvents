using GenericDelegates;

Temperature t = new();

UsingFunc(t);
UsingAction(t);
Console.ReadKey();

void UsingFunc(Temperature t)
{
    Func<double, double> convertToCelsius = t.ToCelsius;
    Func<double, double> convertToFahrenheit = t.ToFahrenheit;

    double celsius = convertToCelsius(90);
    double fahrenheit = convertToFahrenheit(25);

    Console.WriteLine("Using Func");
    Console.WriteLine($"Celsius: {celsius:n2}");
    Console.WriteLine($"Fahrenheit: {fahrenheit:n2}");
    Console.WriteLine();
}

void UsingAction(Temperature t)
{
    Action<double> printCelsius = t.PrintCelsius;
    Action<double> printFahrenheit = t.PrintFahrenheit;

    Console.WriteLine("Using Action");
    printCelsius(80);
    printFahrenheit(20);
    Console.WriteLine();
}