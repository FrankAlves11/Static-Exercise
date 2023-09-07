using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5.0 / 9.0;

        }

        public static double CelciusToFahrenheit(double celsius)
        {
            return (celsius * 9.0 / 5.0) + 32;
        }

    }  
}    
