// Construir un programa que pida por pantalla 3 números y luego diga cuál es el
// mayor de los números ingresados.
public class TallerPunto9
{
    static void Main(string[] args)
    {

        double num1, num2, num3; // Datos de entrada: num1, num2, num3

        Console.Write("Ingrese el primer numero:"); // Pedir numeros
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo numero:");
        num2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer numero:");
        num3 = double.Parse(Console.ReadLine());

        if (num1 > num2 && num1 > num3) //Proceso / impresion del resultado
        {
            Console.WriteLine($"El número {num1} es mayor:");
        } 
        else if (num2 > num3 && num2 > num1)
        {
            Console.WriteLine($"El número {num2} es mayor:");
        }
        else
        {
            Console.WriteLine($"El número {num3} es mayor:");
        }
    }
}
