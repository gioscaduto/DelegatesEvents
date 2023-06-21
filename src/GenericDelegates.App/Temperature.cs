namespace GenericDelegates
{
    public class Temperature
    {
        public double ToFahrenheit(double celsius) => (celsius * 9 / 5) + 32;

        public double ToCelsius(double fahrenheit) => (fahrenheit - 32) * 5 / 9;

        public void PrintFahrenheit(double celsius) => Console.WriteLine($"Fahrenheit: {ToFahrenheit(celsius):n2}");

        public void PrintCelsius(double fahrenheit) => Console.WriteLine($"Celsius:{ToCelsius(fahrenheit):n2}");
    }
}