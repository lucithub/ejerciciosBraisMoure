import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

/**
 * Crea un programa se encargue de transformar un número
 * decimal a binario sin utilizar funciones propias del lenguaje que lo hagan directamente.
 **/
public class DecimalConverter {
    public String DtoB(int numero){
        int residuo = 0;
        List<Integer> residuos = new ArrayList<>();
        while (numero != 0){
            residuo = numero % 2;
            residuos.add(residuo);
            numero = numero / 2;
        }
        Collections.reverse(residuos);
        StringBuilder sb = new StringBuilder();
        for (Integer n : residuos){
            sb.append(n);
        }
        return sb.toString();
    }
}
