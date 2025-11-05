using _10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    /*
     * Crea un programa que sea capaz de transformar texto natural a código
     * morse y viceversa.
     * - Debe detectar automáticamente de qué tipo se trata y realizar
     *   la conversión.
     * - En morse se soporta raya "—", punto ".", un espacio " " entre letras
     *   o símbolos y dos espacios entre palabras "  ".
     * - El alfabeto morse soportado será el mostrado en
     *   https://es.wikipedia.org/wiki/Código_morse.
     */
    public class NaturalToMorse
    {
        private static Dictionary<char, string> NATURAL_TO_MORSE = new Dictionary<char, string>();
        private static Dictionary<string, char> MORSE_TO_NATURAL = new Dictionary<string, char>();
        private static LanguageDetecter detecter = new LanguageDetecter();

        public static void RellenarDictionaries(){
            NATURAL_TO_MORSE.Add('A', ".-");
            NATURAL_TO_MORSE.Add('B', "-...");
            NATURAL_TO_MORSE.Add('C', "-.-.");
            NATURAL_TO_MORSE.Add('D', "-..");
            NATURAL_TO_MORSE.Add('E', ".");
            NATURAL_TO_MORSE.Add('F', "..-.");
            NATURAL_TO_MORSE.Add('G', "--.");
            NATURAL_TO_MORSE.Add('H', "....");
            NATURAL_TO_MORSE.Add('I', "..");
            NATURAL_TO_MORSE.Add('J', ".---");
            NATURAL_TO_MORSE.Add('K', "-.-");
            NATURAL_TO_MORSE.Add('L', ".-..");
            NATURAL_TO_MORSE.Add('M', "--");
            NATURAL_TO_MORSE.Add('N', "-.");
            NATURAL_TO_MORSE.Add('O', "---");
            NATURAL_TO_MORSE.Add('P', ".--.");
            NATURAL_TO_MORSE.Add('Q', "--.-");
            NATURAL_TO_MORSE.Add('R', ".-.");
            NATURAL_TO_MORSE.Add('S', "...");
            NATURAL_TO_MORSE.Add('T', "-");
            NATURAL_TO_MORSE.Add('U', "..-");
            NATURAL_TO_MORSE.Add('V', "...-");
            NATURAL_TO_MORSE.Add('W', ".--");
            NATURAL_TO_MORSE.Add('X', "-..-");
            NATURAL_TO_MORSE.Add('Y', "-.--");
            NATURAL_TO_MORSE.Add('Z', "--..");
            NATURAL_TO_MORSE.Add('0', "-----");
            NATURAL_TO_MORSE.Add('1', ".----");
            NATURAL_TO_MORSE.Add('2', "..---");
            NATURAL_TO_MORSE.Add('3', "...--");
            NATURAL_TO_MORSE.Add('4', "....-");
            NATURAL_TO_MORSE.Add('5', ".....");
            NATURAL_TO_MORSE.Add('6', "-....");
            NATURAL_TO_MORSE.Add('7', "--...");
            NATURAL_TO_MORSE.Add('8', "---..");
            NATURAL_TO_MORSE.Add('9', "----.");
            NATURAL_TO_MORSE.Add(' ', "   ");

            // Se invierte para hacer el map de morse to natural
            foreach (var entry in NATURAL_TO_MORSE)
            {
                MORSE_TO_NATURAL.Add(entry.Value, entry.Key);
            }
        }

        public string Convertir(string sentence)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            if (detecter.WhatLanguageIs(sentence) == 'N')
            {
                foreach (char character in sentence)
                {
                    if (NATURAL_TO_MORSE.TryGetValue(char.ToUpper(character), out string morseCode))
                    {
                        sb.Append(morseCode);
                        if (morseCode != "   ")
                        {
                            sb.Append(" ");
                        }
                    }
                }
                return sb.ToString().TrimEnd(' ');
            }
            else
            {
                string[] words = sentence.Split(new string[] { "   " }, StringSplitOptions.None);
                for (int i = 0; i < words.Length; i++)
                {
                    string morseWord = words[i];
                    string[] morseLetters = morseWord.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string morseLetter in morseLetters)
                    {
                        if (MORSE_TO_NATURAL.TryGetValue(morseLetter, out char character))
                        {
                            sb.Append(character);
                        }
                    }
                    if (i < words.Length - 1)
                    {
                        sb.Append(" ");
                    }
                }

                return sb.ToString().Trim();
            }
        }
    }
}
