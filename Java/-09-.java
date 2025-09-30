/**
 * Crea un programa se encargue de transformar un número
 * decimal a binario sin utilizar funciones propias del lenguaje que lo hagan directamente.
 **/
public class DecimalConverter {
    public Integer DtoB(Integer numero){
        Integer cociente = 0, residuo = 0;
        List<Integer> residuos = new ArrayList<>();
        do {
            cociente = Math.round(numero / 2);
            residuo = Math.round(numero % 2);
            residuos.add(residuo);

        } while (cociente != 0);
        residuos = residuos.reversed();
        StringBuilder sb = new StringBuilder();
        for (Integer n : residuos){
            sb.append(n);
        }
        return Integer.parseInt(sb.toString());
    }
}