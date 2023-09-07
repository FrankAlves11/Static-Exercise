namespace StaticExercise
{
    public class Program
    {
        static void Main()
        {
            double fahrenheit = 212;
            double celsius = 100;

            Console.WriteLine($"{fahrenheit}°F is {TempConverter.FahrenheitToCelsius(fahrenheit)}°C.");
            Console.WriteLine($"{celsius}°C is {TempConverter.CelciusToFahrenheit(celsius)}°F.");

        }
    }
}
