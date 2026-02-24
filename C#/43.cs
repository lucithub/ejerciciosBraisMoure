using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43
{
    /*
     * Crea una función que transforme grados Celsius en Fahrenheit
     * y viceversa.
     *
     * - Para que un dato de entrada sea correcto debe poseer un símbolo "°"
     *   y su unidad ("C" o "F").
     * - En caso contrario retornará un error.
     */
    public class TemperatureConverter
    {
        public double InputHandler(string temperature)
        {
            temperature = temperature.Trim().ToUpper();
            if (temperature.EndsWith("°C") || temperature.EndsWith("C°"))
            {
                return CelsiusToFahrenheit(temperature);
            }
            else if (temperature.EndsWith("°F") || temperature.EndsWith("F°"))
            {
                return FahrenheitToCelsius(temperature);
            }
            throw new ArgumentException("Wrong format. Must include '°C' o '°F'.");
        }

        private double CelsiusToFahrenheit(string temperature)
        {
            double number = double.Parse(temperature[..^2]);
            return (number * 1.8) + 32;
        }
        private double FahrenheitToCelsius(string temperature)
        {
            double number = double.Parse(temperature[..^2]);
            return (number - 32) / 1.8;
        }
    }
}
