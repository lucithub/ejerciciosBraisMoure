using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05
{
    /*
     * Crea una única función (importante que sólo sea una) que sea capaz
     * de calcular y retornar el área de un polígono.
     * - La función recibirá por parámetro sólo UN polígono a la vez.
     * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
     * - Imprime el cálculo del área de un polígono de cada tipo.
     */
    public class Poligono
    {
        public Object areaPoligono(string poligono, int b, int a)
        {
            poligono = poligono.Trim().ToLower();
            poligono = QuitarTildes(poligono);
            switch (poligono)
            {
                case "triangulo":
                    return (b * a) / 2;
                case "cuadrado":
                    return a * a;
                case "rectangulo":
                    return b * a;
                default:
                    return "Ingrese otro poligono. Los polígonos soportados son: Triángulo, Cuadrado y Rectángulo.";
            }
        }

        public static string QuitarTildes(string texto)
        {
            string textoSinTildes = texto;
            textoSinTildes = textoSinTildes.Replace('Á', 'A');
            textoSinTildes = textoSinTildes.Replace('É', 'E');
            textoSinTildes = textoSinTildes.Replace('Í', 'I');
            textoSinTildes = textoSinTildes.Replace('Ó', 'O');
            textoSinTildes = textoSinTildes.Replace('Ú', 'U');
            textoSinTildes = textoSinTildes.Replace('á', 'a');
            textoSinTildes = textoSinTildes.Replace('é', 'e');
            textoSinTildes = textoSinTildes.Replace('í', 'i');
            textoSinTildes = textoSinTildes.Replace('ó', 'o');
            textoSinTildes = textoSinTildes.Replace('ú', 'u');
            textoSinTildes = textoSinTildes.Replace('Ñ', 'N');
            textoSinTildes = textoSinTildes.Replace('ñ', 'n');

            return textoSinTildes;
        }
    }
}
