public class DetectLanguage {
    public Character whatLanguageIs(String sentence){
        if (sentence.contains("-") && sentence.contains(".") && sentence.contains(" ")){
            return 'M';
        }
        return 'N';
    }
}
