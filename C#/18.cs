using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    /*
     * Crea una función que evalúe si un/a atleta ha superado correctamente una
     * carrera de obstáculos.
     * - La función recibirá dos parámetros:
     *      - Un array que sólo puede contener String con las palabras
     *        "run" o "jump"
     *      - Un String que represente la pista y sólo puede contener "_" (suelo)
     *        o "|" (valla)
     * - La función imprimirá cómo ha finalizado la carrera:
     *      - Si el/a atleta hace "run" en "_" (suelo) y "jump" en "|" (valla)
     *        será correcto y no variará el símbolo de esa parte de la pista.
     *      - Si hace "jump" en "_" (suelo), se variará la pista por "x".
     *      - Si hace "run" en "|" (valla), se variará la pista por "/".
     * - La función retornará un Boolean que indique si ha superado la carrera.
     * Para ello tiene que realizar la opción correcta en cada tramo de la pista.
     */
    public class CarreraDeObstaculos
    {
        public bool SuperoLosObstaculos(List<string> acciones, string pista)
        {
            int i = 0;
            char[] pistaArray = pista.ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach (char c in pistaArray)
            {
                if (i >= acciones.Count)
                {
                    Console.WriteLine("ERROR: El atleta se quedo sin acciones antes de terminar la pista.");
                    sb.Append(c);
                    return false;
                }
                if (acciones[i].ToLower() == "run")
                {
                    if (c == '|')
                    {
                        sb.Append("/");
                    }
                    else if (c == '_')
                    {
                        sb.Append("_");
                    }
                    else
                    {
                        Console.WriteLine("Ingreso un formato de pista incorrecto.");
                    }
                }
                else if (acciones[i].ToLower() == "jump")
                {
                    if (c == '|')
                    {
                        sb.Append("|");
                    }
                    else if (c == '_')
                    {
                        sb.Append("x");
                    }
                    else
                    {
                        Console.WriteLine("Ingreso un formato de pista incorrecto.");
                    }
                }
                else
                {
                    Console.WriteLine("Ingreso una accion incorrecta, solo se puede 'RUN' o 'JUMP'.");
                }
                i++;
            }
            Console.WriteLine("La pista quedo de la siguiente manera: "+sb+". El atleta, ha superado los obstaculos? -> "+(pista == sb.ToString()));
            return pista == sb.ToString();
        }
    }
}
