using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    /*
     * Crea un programa que calcule el daño de un ataque durante
     * una batalla Pokémon.
     * - La fórmula será la siguiente: daño = 50 * (ataque / defensa) * efectividad
     * - Efectividad: x2 (súper efectivo), x1 (neutral), x0.5 (no es muy efectivo)
     * - Sólo hay 4 tipos de Pokémon: Agua, Fuego, Planta y Eléctrico 
     *   (buscar su efectividad)
     * - El programa recibe los siguientes parámetros:
     *  - Tipo del Pokémon atacante.
     *  - Tipo del Pokémon defensor.
     *  - Ataque: Entre 1 y 100.
     *  - Defensa: Entre 1 y 100.
     */
    public class BatallaPokemon
    {
        public double Battle(string attackingPokemon, string defenderPokemon, int attack, int defense)
        {
            attackingPokemon = attackingPokemon.ToLower();
            defenderPokemon = defenderPokemon.ToLower();
            double effectiveness = CalculateEffectiveness(attackingPokemon, defenderPokemon);
            return 50 * ((double)attack / defense) * effectiveness;
        }

        private double CalculateEffectiveness(string attackingPokemon, string defenderPokemon)
        {
            switch (attackingPokemon)
            {
                case "agua":
                    if (defenderPokemon == "fuego") return 2;
                    else if (defenderPokemon == "planta") return 0.5;
                    else return 1;
                case "fuego":
                    if (defenderPokemon == "planta") return 2;
                    else if (defenderPokemon == "agua") return 0.5;
                    else return 1;
                case "planta":
                    if (defenderPokemon == "agua") return 2;
                    else if (defenderPokemon == "fuego") return 0.5;
                    else return 1;
                case "electrico":
                    if (defenderPokemon == "agua") return 2;
                    else if (defenderPokemon == "electrico" || defenderPokemon == "planta") return 0.5;
                    else return 1;
                default:
                    return 0;
            }
        }
    }
}
