import java.util.HashMap;
import java.util.Map;

public class Convertor {
    private static final Map<Character, String> NATURAL_TO_MORSE = new HashMap<>();
    private static final Map<String, Character> MORSE_TO_NATURAL = new HashMap<>();
    private static final DetectLanguage detecter = new DetectLanguage();

    static {
        NATURAL_TO_MORSE.put('A', ".-");
        NATURAL_TO_MORSE.put('B', "-...");
        NATURAL_TO_MORSE.put('C', "-.-.");
        NATURAL_TO_MORSE.put('D', "-..");
        NATURAL_TO_MORSE.put('E', ".");
        NATURAL_TO_MORSE.put('F', "..-.");
        NATURAL_TO_MORSE.put('G', "--.");
        NATURAL_TO_MORSE.put('H', "....");
        NATURAL_TO_MORSE.put('I', "..");
        NATURAL_TO_MORSE.put('J', ".---");
        NATURAL_TO_MORSE.put('K', "-.-");
        NATURAL_TO_MORSE.put('L', ".-..");
        NATURAL_TO_MORSE.put('M', "--");
        NATURAL_TO_MORSE.put('N', "-.");
        NATURAL_TO_MORSE.put('O', "---");
        NATURAL_TO_MORSE.put('P', ".--.");
        NATURAL_TO_MORSE.put('Q', "--.-");
        NATURAL_TO_MORSE.put('R', ".-.");
        NATURAL_TO_MORSE.put('S', "...");
        NATURAL_TO_MORSE.put('T', "-");
        NATURAL_TO_MORSE.put('U', "..-");
        NATURAL_TO_MORSE.put('V', "...-");
        NATURAL_TO_MORSE.put('W', ".--");
        NATURAL_TO_MORSE.put('X', "-..-");
        NATURAL_TO_MORSE.put('Y', "-.--");
        NATURAL_TO_MORSE.put('Z', "--..");
        NATURAL_TO_MORSE.put('0', "-----");
        NATURAL_TO_MORSE.put('1', ".----");
        NATURAL_TO_MORSE.put('2', "..---");
        NATURAL_TO_MORSE.put('3', "...--");
        NATURAL_TO_MORSE.put('4', "....-");
        NATURAL_TO_MORSE.put('5', ".....");
        NATURAL_TO_MORSE.put('6', "-....");
        NATURAL_TO_MORSE.put('7', "--...");
        NATURAL_TO_MORSE.put('8', "---..");
        NATURAL_TO_MORSE.put('9', "----.");
        NATURAL_TO_MORSE.put(' ', "   ");

        // Se invierte para hacer el map de morse to natural
        for (Map.Entry<Character, String> entry : NATURAL_TO_MORSE.entrySet()) {
            MORSE_TO_NATURAL.put(entry.getValue(), entry.getKey());
        }
    }

    public String convertir(String sentence){
        StringBuilder sb = new StringBuilder();
        if (detecter.whatLanguageIs(sentence) == 'N'){
            for (Character character : sentence.toCharArray()){
                sb.append(NATURAL_TO_MORSE.get(character));
            }
            return sb.toString();
        }
        else {
            String[] words = sentence.split("   ");
            for (String morseWord : words) {
                String[] morseLetters = morseWord.split(" ");
                for (String morseLetter : morseLetters) {
                    Character character = MORSE_TO_NATURAL.get(morseLetter);
                    if (character != null) {
                        sb.append(character);
                    }
                }
                sb.append(" ");
            }
            return sb.toString().trim();
        }
    }
}
