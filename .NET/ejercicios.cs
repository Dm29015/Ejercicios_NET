
internal class Ejercicios
{
    public static void Main(string[] args)
    {
       Calculadora();
       Divisas();
       Candidatos();
       listaNumeros();
    }

    public static void Calculadora()
    {
        Console.WriteLine("Ingrese el primer número");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int suma = numero1 + numero2;
        int resta = numero1 - numero2;
        int multiplicacion = numero1 * numero2;
        float division = numero1 / numero2;
        int modulo = numero1 % numero2;

        Console.WriteLine($"\nRESULTADO DE OPERACIONES \n\nSUMA: {suma} \nRESTA: {resta} \nMULTIPLICACIÓN: {multiplicacion} \nDIVISIÓN: {division} \nMODULO: {modulo}");
    }

    public static void Divisas()
    {
        Console.WriteLine("\tCONVERSIÓN DE MONEDA \n1. DE COP A USD \n2. DE USD A COP");
        int opcion = Convert.ToInt32(Console.ReadLine());

        double valor;

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingrese la cantidad en COP:");
                valor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"\nEquivalente en Dólares: {(valor * 0.00025):C}");
                break;

            case 2:
                Console.WriteLine("Ingrese la cantidad en USD:");
                valor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"\nEquivalente en Pesos Colombianos: {(valor * 3892.37):C}");
                break;

            default:
                Console.WriteLine("Ingrese una opción válida");
                break;
        }    
    }

    public static void Candidatos()
    {

    }

    public static void listaNumeros()
    {
        List <int> numeros = new List <int>();
        int numero;

        do {
            Console.WriteLine("Ingrese un número");
            numero = Convert.ToInt32(Console.ReadLine());

            numeros.Add(numero);

        } while (numero != -99);

        Console.WriteLine($"\nSe ingresaron {numeros.Count} números. \nNúmero Mayor {numeros.Max()} \nNúmero Menor {numeros.Min()}");
        
        
    }
}