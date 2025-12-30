/*
 * Crea una función que imprima los 30 próximos años bisiestos
 * siguientes a uno dado.
 * - Utiliza el menor número de líneas para resolver el ejercicio.
 */
public class LeapYear
{
    private int _count;
    public void Next30LeapYears(int year)
    {
        _count = 0;
        for (int i = year + 1; _count < 30; i++)
        {
            if (DateTime.IsLeapYear(i))
            {
                Console.WriteLine(i);
                _count++;
            } 
        }
    }
}
