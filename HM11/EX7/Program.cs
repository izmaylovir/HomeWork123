public static class TemperatureConverter
{
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите температуру в Цельсиях:");
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            double fahrenheit = TemperatureConverter.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius} °C = {fahrenheit} °F");
        }
        else
        {
            Console.WriteLine("Некорректный ввод!");
        }

        Console.WriteLine("Введите температуру в Фаренгейтах:");
        if (double.TryParse(Console.ReadLine(), out double fahrenheitInput))
        {
            double celsiusResult = TemperatureConverter.FahrenheitToCelsius(fahrenheitInput);
            Console.WriteLine($"{fahrenheitInput} °F = {celsiusResult} °C");
        }
        else
        {
            Console.WriteLine("Некорректный ввод!");
        }
    }
}