using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44
{
    /*
     * Este es un reto especial por Halloween.
     * Deberemos crear un programa al que le indiquemos si queremos realizar "Truco
     * o Trato" y un listado (array) de personas con las siguientes propiedades:
     * - Nombre de la niña o niño
     * - Edad
     * - Altura en centímetros
     *
     * Si las personas han pedido truco, el programa retornará sustos (aleatorios)
     * siguiendo estos criterios:
     * - Un susto por cada 2 letras del nombre por persona
     * - Dos sustos por cada edad que sea un número par
     * - Tres sustos por cada 100 cm de altura entre todas las personas
     * - Sustos: 🎃 👻 💀 🕷 🕸 🦇
     *
     * Si las personas han pedido trato, el programa retornará dulces (aleatorios)
     * siguiendo estos criterios:
     * - Un dulce por cada letra de nombre
     * - Un dulce por cada 3 años cumplidos hasta un máximo de 10 años por persona
     * - Dos dulces por cada 50 cm de altura hasta un máximo de 150 cm por persona
     * - Dulces: 🍰 🍬 🍡 🍭 🍪 🍫 🧁 🍩
     * - En caso contrario retornará un error.
     */
    public class TrucoTrato
    {
        private string[] sustos = { "🎃", "👻", "💀", "🕷", "🕸", "🦇" };
        private string[] dulces = { "🍰", "🍬", "🍡", "🍭", "🍪", "🍫", "🧁", "🍩" };
        private Random rnd = new Random();

        public string[] TrucoOTrato(string decision, Persona[] personas)
        {
            if (personas.Length == 0) throw new ArgumentException("Ingrese personas.");
            decision = decision.ToLower().Trim();
            if (decision == "truco")
            {
                return CalcularSustos(personas);
            }
            else if (decision == "trato")
            {
                return CalcularDulces(personas);
            }
            else throw new ArgumentException("Indique si quiere truco o trato.");
        }

        private string[] CalcularSustos(Persona[] personas)
        {
            int count = 0;
            foreach (Persona persona in personas)
            {
                count = count + (int)Math.Floor((double)persona.nombre.Length / 2);
                count = count + ((int)Math.Floor((double)persona.edad / 2) * 2);
                count = count + ((int)Math.Floor((double)persona.alturaCM / 100) * 3);
            }
            List<string> sustos = new List<string>();
            for (int i = 0; i < count; i++)
            {
                sustos.Add(this.sustos[this.rnd.Next(this.sustos.Length)]);
            }
            return sustos.ToArray();
        }
        private string[] CalcularDulces(Persona[] personas)
        {
            int count = 0;
            foreach (Persona persona in personas)
            {
                count = count + (persona.nombre.Length);
                if (persona.edad <= 10) count = count + ((int)Math.Floor((double)persona.edad / 3));
                if (persona.alturaCM <= 150) count = count + (((int)Math.Floor((double)persona.alturaCM / 50)) * 2);
            }
            List<string> dulces = new List<string>();
            for (int i = 0; i < count; i++)
            {
                dulces.Add(this.dulces[this.rnd.Next(this.dulces.Length)]);
            }
            return dulces.ToArray();
        }
    }
}
