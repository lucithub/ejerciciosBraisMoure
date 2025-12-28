using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29
{
    /*
     * Simula el funcionamiento de una máquina expendedora creando una operación
     * que reciba dinero (array de monedas) y un número que indique la selección
     * del producto.
     * - El programa retornará el nombre del producto y un array con el dinero
     *   de vuelta (con el menor número de monedas).
     * - Si el dinero es insuficiente o el número de producto no existe,
     *   deberá indicarse con un mensaje y retornar todas las monedas.
     * - Si no hay dinero de vuelta, el array se retornará vacío.
     * - Para que resulte más simple, trabajaremos en céntimos con monedas
     *   de 5, 10, 50, 100 y 200.
     * - Debemos controlar que las monedas enviadas estén dentro de las soportadas.
     */
    public class MaquinaExpendedora
    {
        private Dictionary<int, (string Nombre, int Precio)> products = new Dictionary<int, (string, int)>
        {
            { 1, ("Agua Mineral", 50) },
            { 2, ("Refresco de Cola", 100) },
            { 3, ("Papas Fritas", 135) },
            { 4, ("Barrita de Chocolate", 70) },
            { 5, ("Sandwich Mixto", 200) },
            { 6, ("Galletas", 115) }         
        };
        public int[] Buy(int[] coins, int productNumber)
        {
            if (productNumber < 1 || productNumber > 6)
            {
                Console.WriteLine("El producto no existe. Intentelo de nuevo.");
                return coins;
            }
            int[] vuelto = Vuelto(coins, products[productNumber].Precio);
            if (vuelto == coins) return coins;
            if (productNumber > 0 && productNumber < 7) Console.WriteLine("Aqui tiene su producto: " + products[productNumber]);
            return vuelto;
        }
        public int[] Vuelto(int[] coins, int target)
        {
            int total = 0;
            foreach (var item in coins)
            {
                if (item != 5 && item != 10 && item != 50 && item != 100 && item != 200) throw new Exception("Monedas no soportadas.");
                total += item;
            }
            if (total < target)
            {
                Console.WriteLine("Dinero insuficiente.");
                return coins; 
            }
            else if (total == target) return Array.Empty<int>();
            // ALGORITMO VORAZ //
            int cambioFaltante = total - target;
            List<int> monedasADevolver = new List<int>();
            int[] monedasDelSistema = { 200, 100, 50, 10, 5 };
            foreach (int monedaValor in monedasDelSistema)
            {
                while (cambioFaltante >= monedaValor)
                {
                    monedasADevolver.Add(monedaValor);
                    cambioFaltante -= monedaValor;
                }
            }
            return monedasADevolver.ToArray();
        }
    }
}
