using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    /*
     * Crea un función, que dado un año, indique el elemento 
     * y animal correspondiente en el ciclo sexagenario del zodíaco chino.
     * - Info: https://www.travelchinaguide.com/intro/astrology/60year-cycle.htm
     * - El ciclo sexagenario se corresponde con la combinación de los elementos
     *   madera, fuego, tierra, metal, agua y los animales rata, buey, tigre,
     *   conejo, dragón, serpiente, caballo, oveja, mono, gallo, perro, cerdo
     *   (en este orden).
     * - Cada elemento se repite dos años seguidos.
     * - El último ciclo sexagenario comenzó en 1984 (Madera Rata).
     */
    public class CicloSexagenarioChino
    {
        private string[] elements = { "", "wood", "fire", "earth", "metal", "water" };
        private string[] animals = { "", "rat", "ox", "tiger", "rabbit", "dragon", "snake", "horse", "sheep", "monkey", "rooster", "dog", "pig" };

        public string WhatYearIs(int year)
        { 
            int indexWuXing = 1;
            int indexAnimals = 1;
            int comparisionYear = 2044;
            if (year > comparisionYear)
            {
                while (year >= comparisionYear + 60) comparisionYear += 60;
            }
            else
            {
                while (year < comparisionYear) comparisionYear -= 60;
            } 
            for (int i = 0; i < 60; i++)
            {
                if ((comparisionYear + i) == year) return new StringBuilder($"The year {year} is: {animals[indexAnimals]} and {elements[indexWuXing]}").ToString();
                else
                {
                    if (i % 2 != 0 && i > 0) indexWuXing++;
                    if (indexWuXing > 5) indexWuXing = 1;
                    indexAnimals++;
                    if (indexAnimals > 12) indexAnimals = 1;
                }
                
            }
            return new StringBuilder("Wrong date.").ToString();
        }
    }
}
