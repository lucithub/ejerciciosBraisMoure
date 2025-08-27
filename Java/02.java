import java.util.HashMap;
import java.util.Map;
import java.util.Objects;

public class Anagrama {
    /*
     * Escribe una función que reciba dos palabras (String) y retorne
     * verdadero o falso (Bool) según sean o no anagramas.
     * - Un Anagrama consiste en formar una palabra reordenando TODAS
     *   las letras de otra palabra inicial.
     * - NO hace falta comprobar que ambas palabras existan.
     * - Dos palabras exactamente iguales no son anagrama.
     */
    public Boolean isAnagram(String p1, String p2){
        p1 = p1.toLowerCase().replaceAll(" ", "");
        p2 = p2.toLowerCase().replaceAll(" ", "");
        if (p1.equals(p2) || p1.length() != p2.length()){
            return false;
        }
        Map<Character, Integer> wordsp1 = new HashMap<>();
        Map<Character, Integer> wordsp2 = new HashMap<>();
        for (int i = 0; i < p1.length(); i++) {
            int valorActualp1 = wordsp1.getOrDefault(p1.charAt(i), 0);
            wordsp1.put(p1.charAt(i), valorActualp1 + 1);
        }
        for (int i = 0; i < p2.length(); i++) {
            int valorActualp2 = wordsp2.getOrDefault(p2.charAt(i), 0);
            wordsp2.put(p2.charAt(i), valorActualp2 + 1);
        }
        for (Character ch : wordsp1.keySet()){
            if (!wordsp2.containsKey(ch)){
                return false;
            }
            if (!Objects.equals(wordsp1.get(ch), wordsp2.get(ch))){
                return false;
            }
        }
        return true;
    }
}
