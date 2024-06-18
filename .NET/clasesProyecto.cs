using System;
//Crear un array de objetos para 2 clases de su proyecto. LLenar e imprimir el array
public class Ejercicio
{
    public static void Main()
    {
        Clientes[] clientes = new Clientes[10];
        Clientes cliente = new Clientes();

        Proveedores[] proveedores = new Proveedores[10];
        Proveedores proveedor = new Proveedores(); 
        
        bool bandera = true;

        while (bandera)
        {
            Console.WriteLine("Ingrese una opcion \n1. Registrar Cliente 2. Registrar Proveedor \n3.Mostrar clientes \n4.Mostrar Proveedores 5.Salir");
            int opcion = int.Parse(Console.ReadLine()!);

            switch (opcion)
            {
                case 1:
                    cliente.RegistrarCliente(clientes);
                    break;

                case 2:
                    proveedor.agregarProveedor(proveedores); 
                    break;
                
                case 3:
                    cliente.mostrarClientes(clientes);
                    break;

                case 4:
                    proveedor.mostrarProveedores(proveedores); 
                    break;

                case 5:
                    bandera = false;
                    break;

                default:
                    Console.WriteLine("Opción invalida");
                    break;
            }
        }
    }

    class Proveedores
    {
        int? NIT;
        string? NombreEmpresa;
        string? Direccion;
        string? NombreVendedor;

        public Proveedores() { }

        public Proveedores(int nit, string nombreEmpresa, string direccion, string nombreVendedor)
        {
            NIT = nit;
            NombreEmpresa = nombreEmpresa;
            Direccion = direccion;
            NombreVendedor = nombreVendedor;
        }


        public void agregarProveedor(Proveedores[] proveedores)
        {
            Console.Write("Ingrese el NIT: ");

            int nit = int.Parse(Console.ReadLine()!);

            Console.Write("Ingrese el nombre de la empresa: ");
            string empresa = Console.ReadLine()!;

            Console.Write("Ingrese la dirección de la empresa: ");
            string direccion = Console.ReadLine()!;

            Console.Write("Ingrese el nombre del vendedor: ");
            string vendedor = Console.ReadLine()!;

            Proveedores proveedor = new Proveedores(nit, empresa, direccion, vendedor);

            for (int i = 0; i < proveedores.Length; i++)
            {
                if (proveedores[i] == null)
                {
                    proveedores[i] = proveedor;
                    Console.Write("Proveedor agregado con éxito");
                    break;
                }
            }
        }

        public void mostrarProveedores(Proveedores[] proveedores)
        {
            foreach (Proveedores p in proveedores)
            {
                Console.WriteLine(p);
            }
        }


        public override string ToString()
        {
            return ($"\n\n\tDATOS DEL PROVEEDOR \nNIT: {NIT} \nEmpresa: {NombreEmpresa} \nDirección: {Direccion} \nVendedor: {NombreVendedor}");
        }
    }

    class Clientes
    {
        string? Documento;
        string? Nombre;
        string? Apellido;
        string? Direccion;
        string? Telefono;

        public Clientes() { }

        public Clientes(string documento, string nombre, string apellido, string direccion, string telefono)
        {
            Documento = documento;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
        }



        public void RegistrarCliente(Clientes[] clientes)
        {
            Console.Write("\t\n NUEVO CLIENTE");

            Console.Write("\nIngrese el documento: ");
            string documento = Console.ReadLine()!;

            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine()!;

            Console.Write("Ingrese el apellido: ");
            string apellido = Console.ReadLine()!;

            Console.Write("Ingrese la dirección: ");
            string direccion = Console.ReadLine()!;

            Console.Write("Ingrese el teléfono: ");
            string telefono = Console.ReadLine()!;

            Clientes cliente = new Clientes(documento, nombre, apellido, direccion, telefono);


            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] == null)
                {
                    clientes[i] = cliente;
                    Console.Write("\nCliente agregado con éxito");
                    break;
                }
            }
        }



        public void mostrarClientes(Clientes[] clientes)
        {
            foreach (Clientes c in clientes)
            {
                Console.WriteLine(c);
            }
        }



        public override string ToString()

        {
            return $"\n\nDocumento: {Documento} \nNombre Completo: {Nombre} {Apellido} \nDirección: {Direccion} \nTeléfono: {Telefono}\n-----------------------------------------------";
        }

    }

}





