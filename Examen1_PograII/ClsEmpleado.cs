using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_PograII
{
    internal class ClsEmpleado
    {
        static int cantidad = 2;
        static public string[] cedula = new string[cantidad];
        static public string[] nombre = new string[cantidad];
        static public string[] Direccion = new string[cantidad];
        static public int[] Telefono= new int[cantidad];
        static public int [] salario=new int [cantidad];

        static public string Inicializar()
        {
            try
            {
                cedula = Enumerable.Repeat("", cantidad).ToArray();
                nombre = Enumerable.Repeat("", cantidad).ToArray();
                Direccion = Enumerable.Repeat("", cantidad).ToArray();
                Telefono = Enumerable.Repeat(0, cantidad).ToArray();
                salario = Enumerable.Repeat(0, cantidad).ToArray();

            }
            catch (Exception)
            {

                return "No se pudo inicializar";
            }
            
            return "Sistema ha sido inicializado";
            
        }
        

        static public void Agregar()
        {
            int cont = 1;
            for (int i = 0; i < cantidad; i++)
            {
                Console.Clear();
                Console.WriteLine("Digite la cedula {0}",cont);
                cedula[i]=Console.ReadLine();
                Console.WriteLine("Digite el nombre {0}", cont);
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Digite la direccion {0}", cont);
                Direccion[i] = Console.ReadLine();
                Console.WriteLine("Digite el telefono {0}", cont);
                int.TryParse(Console.ReadLine(), out Telefono[i]);
                Console.WriteLine("Digite el salario {0}", cont);
                int.TryParse(Console.ReadLine(), out salario[i]);
                cont++;
            }
        }

        public static string SolicitaCed()
        {
            Console.WriteLine("Digite la cedula: ");
            string ced = Console.ReadLine();
            return ced;
        }

        public static void Consultar(string ced)
        {
            Boolean encontrado = false;
            
            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    Console.WriteLine($"Nombre: {nombre[i]}, Direccion: {Direccion[i]}, Telefono: {Telefono[i]} y Salario: {salario[i]}");
                    encontrado = true;
                    break;

                }
            }
            if (encontrado == false)
            {
                Console.WriteLine($"La cedula: {ced} no existe");
            }
        }



        static public void modificar()
        {

            Boolean encontrado = false;
            Console.WriteLine("Digite la cedula:");
            string ced = Console.ReadLine();
            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    Console.WriteLine("Digite el nombre:");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("Digite la direccion:");
                    Direccion[i] = Console.ReadLine();
                    Console.WriteLine("Digite el telefono:");
                    int.TryParse(Console.ReadLine(), out Telefono[i]);
                    Console.WriteLine("Digite el salario:");
                    int.TryParse(Console.ReadLine(),out salario[i]);
                    encontrado = true;
                    break;

                }
            }
            if (encontrado == false)
            {
                Console.WriteLine("Empleado no encontrado");
            }
        }

        static public void Borrar(string ced)
        {
            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    cedula[i] = "";
                    nombre[i] = "";
                    Direccion[i] = "";
                    Telefono[i] = 0;
                    salario[i] = 0;
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine($" El empleado con la cédula {ced} ha sido eliminado.");
            }
            else
            {
                Console.WriteLine($"El empleado con la cédula {ced} no se encontró.");
            }



        }
       
        static public void listaEmpleados()
        {
            Console.WriteLine("Listado de Empleados:");

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Cedula: {cedula[i]}, Nombre: {nombre[i]}, Dirección: {Direccion[i]}, Teléfono: {Telefono[i]}, Salario: {salario[i]}");
                Console.WriteLine("----------------------------------------");

            }

        }

       

        public static void PromedioSalario( )
        {
            if (salario.Length > 0)
            {
                double promedio = salario.Average();
                Console.WriteLine("El promedio de los salarios es: " + promedio);
            }
        }

        public static void SalarioAltoBajo()
        {
            if (salario.Length > 0)
            {
                Console.WriteLine("El salario máximo es: " + salario.Max());
                Console.WriteLine("El salario mínimo es: " + salario.Min());

            }
        }
    }
}
