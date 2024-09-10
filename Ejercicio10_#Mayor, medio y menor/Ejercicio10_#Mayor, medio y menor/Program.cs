public class Program
{
    private static void Main(string[] args)
    {
        //10. construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor, el del medio y el menor de los números registrados

        Console.WriteLine("Hello, World!");

        // aqui ingresamos las variables 
        Console.WriteLine("Ingrese el primer número:");
        int número1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int número2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número:");
        int número3 = Convert.ToInt32(Console.ReadLine());

        // Declaramos variables para los valores mayor, medio y menor
        int mayor, medio, menor;

        // en esta parte comparamos los números para encontrar el mayor, el medio y el menor
        if (número1 > número2 && número1 > número3)
        {
            mayor = número1;
            if (número2 > número3)
            {
                medio = número2;
                menor = número3;
            }
            else
            {
                medio = número3;
                menor = número2;
            }
        }
        else if (número2 > número1 && número2 > número3)
        {
            mayor = número2;
            if (número1 > número3)
            {
                medio = número1;
                menor = número3;
            }
            else
            {
                medio = número3;
                menor = número1;
            }
        }
        else
        {
            mayor = número3;
            if (número1 > número2)
            {
                medio = número1;
                menor = número2;
            }
            else
            {
                medio = número2;
                menor = número1;
            }
        }

        // en esta parte mostramos los resultados solicitados 
        Console.WriteLine($"El número mayor es: {mayor}");
        Console.WriteLine($"El número del medio es: {medio}");
        Console.WriteLine($"El número menor es: {menor}");
    }
}