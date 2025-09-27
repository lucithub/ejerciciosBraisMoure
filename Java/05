import java.util.Locale;
import java.text.Normalizer;
import java.util.regex.Pattern;

/*
 * Crea una única función (importante que sólo sea una) que sea capaz
 * de calcular y retornar el área de un polígono.
 * - La función recibirá por parámetro sólo UN polígono a la vez.
 * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
 * - Imprime el cálculo del área de un polígono de cada tipo.
 */
public class Poligono {
    private Integer area;
    public Integer calcularArea(String tipo, Integer base, Integer altura){
        tipo = tipo.toLowerCase(Locale.ROOT);
        tipo = Normalizer.normalize(tipo, Normalizer.Form.NFD);
        Pattern patron = Pattern.compile("\\p{M}");
        tipo = patron.matcher(tipo).replaceAll("");
        switch (tipo){
            case "triangulo":
                area = (base * altura) / 2;
                break;
            case "cuadrado":
                area = altura * altura;
                break;
            case "rectangulo":
                area = base * altura;
                break;
            default:
                throw new IllegalArgumentException("Polígono no soportado. Debe ser Triángulo, Cuadrado o Rectángulo.");
        }
        return area;
    }
}
