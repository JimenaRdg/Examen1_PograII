using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_PograII
{
    internal class ClsMenu
    {
        static int opcion=0;

        static public void menu()
        {
            do
            {
                Console.WriteLine("*** Bienvenido al sistema de recursos humanos ***");
                Console.WriteLine("1- Inicializar");
                Console.WriteLine("2- Agregar empleados");
                Console.WriteLine("3- Consultar empleados");
                Console.WriteLine("4- Modificar empleados");
                Console.WriteLine("5- Borrar empleados");
                Console.WriteLine("6- Reportes");
                Console.WriteLine("7- Salir");
                Console.WriteLine("Digite un valor");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1: Console.WriteLine(ClsEmpleado.Inicializar()); break;
                    case 2: Console.Clear(); ClsEmpleado.Agregar(); break;
                    case 3: Console.Clear(); ClsEmpleado.Consultar(ClsEmpleado.SolicitaCed()); break;
                    case 4: Console.Clear(); ClsEmpleado.modificar(); break;
                    case 5: Console.Clear(); ClsEmpleado.Borrar(ClsEmpleado.SolicitaCed()); break;
                    case 6: Console.Clear(); submenu();break;
                    case 7:  break;
                       

                    default:
                        break;
                }

            } while ( opcion!=7);
        }

        static public void submenu()
        {
            do
            {
                Console.WriteLine("1- Consultar empleado");
                Console.WriteLine("2- Listado de empleados");
                Console.WriteLine("3- Promedio de salarios ");
                Console.WriteLine("4- Salario mas alto y salario mas bajo");
                Console.WriteLine("5- Regresar");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: ClsEmpleado.Consultar(ClsEmpleado.SolicitaCed()); break;
                    case 2: Console.Clear(); ClsEmpleado.listaEmpleados(); break;
                    case 3: Console.Clear(); ClsEmpleado.PromedioSalario(); break;
                    case 4: Console.Clear(); ClsEmpleado.SalarioAltoBajo(); break;
                    case 5: ClsMenu.menu(); break;
                    default:
                        break;
                }

            } while (opcion!=5);
        }
    }
}
