import java.math.BigDecimal;
import java.math.BigInteger;
import java.math.RoundingMode;

/*
 * Crea un programa que se encargue de calcular el aspect ratio de una
 * imagen a partir de una url.
 * - Url de ejemplo:
 *   https://raw.githubusercontent.com/mouredevmouredev/master/mouredev_github_profile.png
 * - Por ratio hacemos referencia por ejemplo a los "16:9" de una
 *   imagen de 1920*1080px.
 */
public class AspectRatio {
    public String calcularRatio(Integer height, Integer width){
        BigDecimal aspectRatioN = new BigDecimal((double) height / width);
        aspectRatioN = aspectRatioN.setScale(2, RoundingMode.HALF_UP);
        Double aspectRatioF = aspectRatioN.doubleValue();
        System.out.println("Relacion de aspecto de: "+ aspectRatioF + ":1");
        /****/
        BigInteger bih = BigInteger.valueOf(height);
        BigInteger biw = BigInteger.valueOf(width);
        BigInteger mcd = bih.gcd(biw);
        return "Relacion de aspecto: "+(height/mcd.intValue())+":"+(width/mcd.intValue());
    }
}
