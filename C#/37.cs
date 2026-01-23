using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37
{
    /*
     * ¡La Tierra Media está en guerra! En ella lucharán razas leales
     * a Sauron contra otras bondadosas que no quieren que el mal reine
     * sobre sus tierras.
     * Cada raza tiene asociado un "valor" entre 1 y 5:
     * - Razas bondadosas: Pelosos (1), Sureños buenos (2), Enanos (3),
     *   Númenóreanos (4), Elfos (5)
     * - Razas malvadas: Sureños malos (2), Orcos (2), Goblins (2),
     *   Huargos (3), Trolls (5)
     * Crea un programa que calcule el resultado de la batalla entre
     * los 2 tipos de ejércitos:
     * - El resultado puede ser que gane el bien, el mal, o exista un empate.
     *   Dependiendo de la suma del valor del ejército y el número de integrantes.
     * - Cada ejército puede estar compuesto por un número de integrantes variable
     *   de cada raza.
     * - Tienes total libertad para modelar los datos del ejercicio.
     * Ej: 1 Peloso pierde contra 1 Orco
     *     2 Pelosos empatan contra 1 Orco
     *     3 Pelosos ganan a 1 Orco
     */
    public class LosAnillosDelPoder
    {
        private static readonly Dictionary<string, int> razasBondadosas = new Dictionary<string, int>
        {
            { "pelosos", 1 },
            { "sureños buenos", 2 },
            { "enanos", 3 },
            { "numenoreanos", 4 },
            { "elfos", 5 }
        };
        private static readonly Dictionary<string, int> razasMalvadas = new Dictionary<string, int>
        {
            { "sureños malos", 2 },
            { "orcos", 2 },
            { "goblins", 2 },
            { "huargos", 3 },
            { "trolls", 5 }
        };
        public string Batalla(Dictionary<string, int> bondadosos, Dictionary<string, int> malvados)
        {
            int totalBondadosos = 0; int totalMakvados = 0;
            foreach (var bondadoso in bondadosos)
            {
                int value = bondadoso.Value;
                string key = bondadoso.Key.ToLower();
                if (!bondadosos.ContainsKey(key)) throw new Exception("Ingrese una raza correspondiente.");
                totalBondadosos = totalBondadosos + (value * razasBondadosas[key]);
            }
            foreach (var malvado in malvados)
            {
                int value = malvado.Value;
                string key = malvado.Key.ToLower();
                if (!malvados.ContainsKey(key)) throw new Exception("Ingrese una raza correspondiente.");
                totalMakvados = totalMakvados + (value * razasMalvadas[key]);
            }
            switch (totalBondadosos - totalMakvados)
            {
                case 0:
                    return "Empate.";
                case > 0:
                    return "Los bondadosos ganan a los malvados.";
                case < 0:
                    return "Los malvados le ganan a los bondadosos.";
            }
        }
    }
}
