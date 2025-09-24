/*
* Escribe una función que reciba dos palabras (String) y retorne
* verdadero o falso (Bool) según sean o no anagramas.
* - Un Anagrama consiste en formar una palabra reordenando TODAS
*   las letras de otra palabra inicial.
* - NO hace falta comprobar que ambas palabras existan.
* - Dos palabras exactamente iguales no son anagrama.
*/
   public class Anagrama
   {
       public bool esAnagrama(string p1, string p2)
       {
           p1 = p1.ToLower().Trim();
           p2 = p2.ToLower().Trim();
           if (p1.Equals(p2)) return false;
           if (p1.Length != p2.Length) return false;
           Dictionary<char, int> mapp1 = new Dictionary<char, int>();
           Dictionary<char, int> mapp2 = new Dictionary<char, int>();
           for (int i = 0; i < p1.Length; i++)
           {
               if (!mapp1.ContainsKey(p1[i]))
               {
                   mapp1.Add(p1[i], 1);
               }
               else
               {
                   mapp1[p1[i]] = mapp1[p1[i]] + 1;
               }
           }
           for (int i = 0; i < p2.Length; i++)
           {
               if (!mapp2.ContainsKey(p2[i]))
               {
                   mapp2.Add(p2[i], 1);
               }
               else
               {
                   mapp2[p2[i]] = mapp2[p2[i]] + 1;
               }
           }
           foreach (char character in mapp1.Keys)
           {
               if (!mapp2.ContainsKey(character)) return false;
               if (mapp1[character] != mapp2[character]) return false;
           }
           return true;
       }
   }