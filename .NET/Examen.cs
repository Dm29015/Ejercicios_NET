
using System.Security.Cryptography;

bool b = true;
    Credito credito = new Credito();

    while (b)
    {
        Console.WriteLine("\n\n\tMENÚ" +
            "\n1.Registrar el valor total de compras." +
            "\n2.Realizar avances." +
            "\n3.Pagar Crédito." +
            "\n4.Consultar crédito disponible, total de puntos y saldo por pagar."+
            "\n5.Salir");
        int opcion = int.Parse(Console.ReadLine()!);

        switch (opcion)
        {
            case 1:
                Console.Write(credito.Comprar());
                break;
            case 2:
                Console.Write(credito.Avance());
                break;
            case 3:
                Console.Write(credito.PagarCredito());
                break;
            case 4:
                credito.ConsultarEstadoCredito();
                break;
            case 5:
                b = false;
                break;
            default:
                Console.WriteLine("\nOpción incorrecta. Por favor digite una opción válida");
                break;
        }
    }


class Credito
{
    double cupo = 1000000;
    double puntos = 0;
    double creditoDisponible = 1000000;
    double valorCompra;
    double valorAvance;
    double saldoPagar = 0;

    public Credito(){}

    public string Comprar()
    {

        Console.Write("\nIngrese el total de la compra: ");
        valorCompra = double.Parse(Console.ReadLine()!);

        if(valorCompra <= 0 || valorCompra > creditoDisponible)
        {
            return("\nEl valor no puede ser inferior a 0 ni puede superar el total de su crédito disponible");
        }
        else
        {
            if(valorCompra >= 100000)
            {
                puntos+= valorCompra * 0.01;
            }
            saldoPagar += valorCompra;
            creditoDisponible = cupo - saldoPagar;
            return ("\n¡Compra realizada con éxito!");
        }
    }

    public string Avance()
    {

        Console.Write("\nIngrese la cantidad a retirar: ");
        valorAvance = double.Parse(Console.ReadLine()!);

        if (valorAvance <= 0 || valorAvance > creditoDisponible)
        {
            return ("\nEl valor no puede ser inferior a 0 ni puede superar el total de su crédito disponible");
        }
        else
        {
            saldoPagar += valorAvance;
            creditoDisponible = cupo - saldoPagar;
            return ("\n¡Avance realizado con éxito!");
        }
    }

    public string PagarCredito()
    {
        Console.WriteLine("\nIngrese la cantidad a abonar: ");
        valorAvance = double.Parse (Console.ReadLine()!);

        if(valorAvance > saldoPagar)
        {
            return($"\nEl abono supera la deuda actual.\nSu deuda actual es de: {saldoPagar}");
        }else if (valorAvance < 0)
        {
            return("\nEl abono no puede ser inferior a 0");
        }
        else
        {   
            saldoPagar -= valorAvance;
            creditoDisponible = cupo - saldoPagar;
            return ("\n¡Pago realizado con éxito!");
        }
    }

    public void ConsultarEstadoCredito()
    {
        Console.WriteLine("\n\tESTADO DE CRÉDITO");
        Console.WriteLine($"\nCrédito disponible: \t{creditoDisponible}");
        Console.WriteLine($"\nCantidad de puntos: \t{puntos}");
        Console.WriteLine($"\nDeuda total actual: \t{saldoPagar}");
    }

}

