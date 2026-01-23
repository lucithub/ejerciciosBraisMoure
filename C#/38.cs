using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38
{
    /*
     * ¡Han anunciado un nuevo "The Legend of Zelda"!
     * Se llamará "Tears of the Kingdom" y se lanzará el 12 de mayo de 2023.
     * Pero, ¿recuerdas cuánto tiempo ha pasado entre los distintos
     * "The Legend of Zelda" de la historia?
     * Crea un programa que calcule cuántos años y días hay entre 2 juegos de Zelda
     * que tú selecciones.
     * - Debes buscar cada uno de los títulos y su día de lanzamiento 
     *   (si no encuentras el día exacto puedes usar el mes, o incluso inventártelo)
     */
    public class LanzamientosTLOZ
    {
        private static Dictionary<string, DateOnly> lanzamientos = new Dictionary<string, DateOnly>
        {
            { "the legend of zelda: ocarina of time", new DateOnly(1998, 12, 11) },
            { "zelda: majora's mask", new DateOnly(2000, 11, 17) },
            { "the legend of zelda: a link to the past", new DateOnly(2003, 03, 24) },
            { "the legend of zelda: the wind waker", new DateOnly(2003, 05, 03) },
            { "the legend of zelda: ocarina of time master quest", new DateOnly(2003, 05, 03) },
            { "the legend of zelda: four swords", new DateOnly(2004, 03, 18) },
            { "the legend of zelda: the minish cap", new DateOnly(2004, 11, 12) },
            { "zelda ii: the adventure of link", new DateOnly(2005, 01, 07) },
            { "the legend of zelda", new DateOnly(2006, 12, 08) },
            { "the legend of zelda: twilight princess", new DateOnly(2006, 12, 08) },
            { "the legend of zelda: phantom hourglass", new DateOnly(2007, 10, 19) },
            { "the legend of zelda: majora's mask", new DateOnly(2009, 04, 03) },
            { "the legend of zelda: spirit tracks", new DateOnly(2009, 12, 11) },
            { "the legend of zelda: link's awakening", new DateOnly(2011, 06, 07) },
            { "the legend of zelda: ocarina of time 3d", new DateOnly(2011, 06, 17) },
            { "the legend of zelda: four swords anniversary edition", new DateOnly(2011, 09, 28) },
            { "the legend of zelda: skyward sword", new DateOnly(2011, 11, 18) },
            { "the legend of zelda: oracle of seasons", new DateOnly(2013, 05, 30) },
            { "the legend of zelda: oracle of ages", new DateOnly(2013, 05, 30) },
            { "the legend of zelda: the wind waker hd", new DateOnly(2013, 10, 04) },
            { "the legend of zelda: a link between worlds", new DateOnly(2013, 11, 22) },
            { "the legend of zelda: majora's mask 3d", new DateOnly(2015, 02, 13) },
            { "the legend of zelda: tri force heroes", new DateOnly(2015, 10, 23) },
            { "the legend of zelda: twilight princess hd", new DateOnly(2016, 03, 04) },
            { "the legend of zelda: skyward sword wii", new DateOnly(2016, 09, 01) },
            { "the legend of zelda: breath of the wild", new DateOnly(2017, 03, 03) },
            { "cadence of hyrule - crypt of the necrodancer featuring the legend of zelda", new DateOnly(2019, 06, 13) },
            { "the legend of zelda: link's awakening remake", new DateOnly(2019, 09, 20) },
            { "the legend of zelda: skyward sword hd", new DateOnly(2021, 07, 16) },
            { "the legend of zelda: tears of the kingdom", new DateOnly(2023, 05, 12) },
            { "the legend of zelda: echoes of wisdom", new DateOnly(2024, 09, 26) },
            { "the legend of zelda: tears of the kingdom - nintendo switch 2 edition", new DateOnly(2025, 06, 05) },
            { "the legend of zelda: breath of the wild - nintendo switch 2 edition", new DateOnly(2025, 06, 05) },
        };
        public string TiempoEntreJuegos(string juego1, string juego2)
        {
            juego1 = juego1.ToLower();
            juego2 = juego2.ToLower();
            if (!lanzamientos.ContainsKey(juego1) || !lanzamientos.ContainsKey(juego2)) throw new Exception("Ingrese un juego valido, o fijese el titulo del juego.");
            string fechaj1 = lanzamientos[juego1].ToString();
            string fechaj2 = lanzamientos[juego2].ToString();
            TimeSpan diferencia = new TimeSpan();
            string[] fechas = fechaj1.Split('/');
            DateTime fechaUno = new DateTime(int.Parse(fechas[2]), int.Parse(fechas[1]), int.Parse(fechas[0]));
            string[] fechasDos = fechaj2.Split('/');
            DateTime fechaDos = new DateTime(int.Parse(fechasDos[2]), int.Parse(fechasDos[1]), int.Parse(fechasDos[0]));
            int years = Math.Abs(int.Parse(fechas[2]) - int.Parse(fechasDos[2]));
            int diasARestar = 365 * years;
            return $"La diferencia entre: {juego1} y {juego2} es de {years} anios y {Math.Abs(Math.Abs((fechaUno - fechaDos).Days) - diasARestar)} dias.";
        }
    }
}
