using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    /*
     * Lee el fichero "Challenge21.txt" incluido en el proyecto, calcula su
     * resultado e imprímelo.
     * - El .txt se corresponde con las entradas de una calculadora.
     * - Cada línea tendrá un número o una operación representada por un
     *   símbolo (alternando ambos).
     * - Soporta números enteros y decimales.
     * - Soporta las operaciones suma "+", resta "-", multiplicación "*"
     *   y división "/".
     * - El resultado se muestra al finalizar la lectura de la última
     *   línea (si el .txt es correcto).
     * - Si el formato del .txt no es correcto, se indicará que no se han
     *   podido resolver las operaciones.
     */
    public class CalculadoraTXT
    {
        public double Calculadora(StreamReader sr)
        {
            double resultado = 0;
            var lineas = new List<string>();
            var line = sr.ReadLine();
            while (line != null)
            {
                lineas.Add(line);
                line = sr.ReadLine();
            }
            if (lineas.Count == 0) return 0;
            resultado = double.Parse(lineas[0]);
            for (int i = 1; i < lineas.Count; i += 2)
            {
                if (i + 1 >= lineas.Count) break;
                string operacion = lineas[i];
                double siguienteNumero = double.Parse(lineas[i + 1]);
                switch (operacion)
                {
                    case "+":
                        resultado += siguienteNumero;
                        break;
                    case "-":
                        resultado -= siguienteNumero;
                        break;
                    case "*":
                        resultado *= siguienteNumero;
                        break;
                    case "/":
                        resultado /= siguienteNumero;
                        break;
                }
            }
            return resultado;
        }
    }
}
