using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET
{
    using System;

    class TALLER1
    {
        static void Main()
        {
            Aprendiz[] aprendices = new Aprendiz[100];
            Venta[] ventas = new Venta[100];

            bool bandera = true;

            while (bandera)
            {
                Console.WriteLine("\n\t MENÚ " +
                    "\n1 Registrar inasistencia\r" +
                    "\n2.Listar todas las Inasistencias\r" +
                    "\n3.Listar los aprendices con inasistencias superiores a 3\r" +
                    "\n4.Consultar el total de inasistencias por aprendiz.\r" +
                    "\n5.Valor a Pagar\r" +
                    "\n6.Número de suerte\r" +
                    "\n7. Salir\r\n");

                int opcion = int.Parse(Console.ReadLine()!);

                switch (opcion)
                {
                    case 1:
                        Aprendiz.RegistrarAprendices(aprendices);
                        break;

                    case 2:
                        Aprendiz.ListarAprendices(aprendices);
                        break;

                    case 3:
                        Aprendiz.Inasistencias3(aprendices);
                        break;

                    case 4:
                        Aprendiz.InasistenciaAprendiz(aprendices);
                        break;

                    case 5:
                        Console.WriteLine(Venta.RegistrarVenta());
                        break;

                    case 6:
                        NumeroAleatorio();
                        break;

                    case 7:
                        bandera = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }


        class Aprendiz
        {
            public int Documento;
            public string NombreCompleto;
            public int Inasistencias;

            public Aprendiz(int documento, string nombreCompleto, int inasistencias)
            {
                Documento = documento;
                NombreCompleto = nombreCompleto;
                Inasistencias = inasistencias;
            }

            public static void RegistrarAprendices(Aprendiz[] aprendices)
            {
                Console.Write("Ingrese el documento: ");
                int Documento = int.Parse(Console.ReadLine()!);

                Console.Write("Ingrese el nombre: ");
                string NombreCompleto = Console.ReadLine()!;

                Console.Write("Ingrese las inasistencias: ");
                int Inasistencias = int.Parse(Console.ReadLine()!);

                Aprendiz aprendiz = new Aprendiz(Documento, NombreCompleto, Inasistencias);

                bool encontrado = false;

                if (Inasistencias < 1 || Inasistencias > 100)
                {
                    Console.WriteLine("Las inasistencias solo se registran en un rango de 1 a 100");
                }
                else
                {
                    foreach(var a in aprendices)
                    {
                        if (a.Documento == aprendiz.Documento)
                        {
                            a.Inasistencias += Inasistencias;
                            encontrado = true;
                            break;
                        }
                    }


                    if (!encontrado)
                    {
                        for(int i = 0; i < aprendices.Length; i++)
                        {
                            if (aprendices[i] == null)
                            {
                                aprendices[i] = aprendiz;
                                break;
                            }
                        }
                    }


                }
            }

            public static void ListarAprendices(Aprendiz[] aprendices)
            {
                if (aprendices.Length == 0)
                {
                    Console.WriteLine("\nNo hay aprendices registrados.");
                }
                else
                {
                    Console.WriteLine("\n\tAprendices registrados \n---------------------------------------------");

                    foreach (var a in aprendices)
                    {
                        if (a != null)
                        {
                            Console.WriteLine(a);
                        }
                    }
                }
            }

            public static void Inasistencias3(Aprendiz[] aprendices)
            {
                foreach (var a in aprendices)
                {
                    if (a.Inasistencias > 3)
                    {
                        Console.WriteLine(a);
                    }
                }
            }

            public static void InasistenciaAprendiz(Aprendiz[] aprendices)
            {
                Console.Write("\nIngrese el documento del estudiante: ");
                int Documento = int.Parse(Console.ReadLine()!);

                bool encontrado = false;
                foreach (var a in aprendices)
                {
                    if (a.Documento == Documento)
                    {
                        Console.WriteLine(a);
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("\nNo se encontró ningún estudiante con ese documento.");
                }
            }

        }

        class Venta
        {
            public string Codigo;
            public string Nombre;
            public double Precio;
            public int Cantidad;

            public Venta(string codigo, string nombre, double precio, int cantidad)
            {
                Codigo = codigo;
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
            }

            public static double RegistrarVenta()
            {
                Console.Write("Ingrese el código: ");
                string? codigo = Console.ReadLine();

                Console.Write("Ingrese el nombre del producto: ");
                string? nombre = Console.ReadLine();

                Console.Write("Ingrese el precio unitario: ");
                double precio = double.Parse(Console.ReadLine()!);

                Console.Write("Ingrese la cantidad: ");
                int cantidad = int.Parse(Console.ReadLine()!);

                if (precio <= 0 || cantidad <= 0)
                {
                    Console.WriteLine("Error: El precio y la cantidad deben ser mayores que 0.");
                    return 0; 
                }

                double valorBruto = precio * cantidad;
                double valorIVA = valorBruto * 0.19;
                double descuento = cantidad > 10 ? valorBruto * 0.10 : 0;

                Console.Write("---------------------------------------");
                Console.WriteLine("Valor bruto: $" + valorBruto);
                Console.WriteLine("Valor del IVA: $" + valorIVA);
                Console.WriteLine("Descuento: $" + descuento);

                double valorPagar = (valorBruto + valorIVA) - descuento;
                return valorPagar;
            }

        }

        public static void NumeroAleatorio()
        {
            Random random = new Random();
            int numero = random.Next(1000);

            string numeroFormateado = numero.ToString("D3");
            Console.Write(numeroFormateado);
        }
    }

       

    

}
