using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    /*
     * Crea un programa que calcule quien gana más partidas al piedra,
     * papel, tijera.
     * - El resultado puede ser: "Player 1", "Player 2", "Tie" (empate)
     * - La función recibe un listado que contiene pares, representando cada jugada.
     * - El par puede contener combinaciones de "R" (piedra), "P" (papel)
     *   o "S" (tijera).
     * - Ejemplo. Entrada: [("R","S"), ("S","R"), ("P","S")]. Resultado: "Player 2".
     */
    public class PiedraPapelTijera
    {
        public string Play(List<Tuple<char, char>> results)
        {
            int countP1 = 0; int countP2 = 0;
            foreach (Tuple<char, char> item in results)
            {
                if (WhoIsWinner(item) == 1) countP1++;
                else if (WhoIsWinner(item) == 2) countP2++;
                else
                {
                    countP1++;
                    countP2++;
                }
            }
            if (countP1 == countP2) return "Tie";
            else
            {
                if (countP1 > countP2) return "Player 1";
                else return "Player 2";
            }
        }

        public int WhoIsWinner(Tuple<char, char> round)
        {
            switch (round.Item1)
            {
                case 'R':
                    if (round.Item2 == 'P') return 2;
                    else if (round.Item2 == 'S') return 1;
                    else return 3;
                case 'P':
                    if (round.Item2 == 'P') return 3;
                    else if (round.Item2 == 'S') return 2;
                    else return 1;
                case 'S':
                    if (round.Item2 == 'P') return 1;
                    else if (round.Item2 == 'S') return 3;
                    else return 2;
                default:
                    return 3;
            }
        }
    }
}
