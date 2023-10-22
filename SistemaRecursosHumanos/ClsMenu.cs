using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecursosHumanos
{
    internal class ClsMenu
    {
        private List<ClsEmpleado> empleados = new List<ClsEmpleado>();

        public void MostrarMenu()
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenú Principal:");
                Console.WriteLine("1. Agregar Empleado");
                Console.WriteLine("2. Consultar Empleado");
                Console.WriteLine("3. Modificar Empleado");
                Console.WriteLine("4. Borrar Empleado");
                Console.WriteLine("5. Inicializar Arreglos");
                Console.WriteLine("6. Reportes");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            AgregarEmpleado();
                            break;
                        case 2:
                            ConsultarEmpleado();
                            break;
                        case 3:
                            ModificarEmpleado();
                            break;
                        case 4:
                            BorrarEmpleado();
                            break;
                        case 5:
                            InicializarArreglos();
                            break;
                        case 6:
                            MostrarReportes();
                            break;
                        case 7:
                            Console.WriteLine("Ha salido del Sistema.");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida.Ingrese una opción.");
                }
            } while (opcion != 7);
        }

        private void AgregarEmpleado()
        {
            Console.Write("Cédula: ");
            string cedula = Console.ReadLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Dirección: ");
            string direccion = Console.ReadLine();
            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine();
            Console.Write("Salario: ");
            if (double.TryParse(Console.ReadLine(), out double salario))
            {
                ClsEmpleado empleado = new ClsEmpleado(cedula, nombre, direccion, telefono, salario);
                empleados.Add(empleado);
                Console.WriteLine("Empleado agregado con éxito.");
            }
            else
            {
                Console.WriteLine("Salario no válido.");
            }
        }

        private void ConsultarEmpleado()
        {
            Console.Write("Ingrese la cédula del empleado a consultar: ");
            string cedula = Console.ReadLine();
            ClsEmpleado empleado = empleados.Find(e => e.Cedula == cedula);
            if (empleado != null)
            {
                Console.WriteLine($"Cédula: {empleado.Cedula}");
                Console.WriteLine($"Nombre: {empleado.Nombre}");
                Console.WriteLine($"Dirección: {empleado.Direccion}");
                Console.WriteLine($"Teléfono: {empleado.Telefono}");
                Console.WriteLine($"Salario: {empleado.Salario}");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        private void ModificarEmpleado()
        {
            Console.Write("Ingrese la cédula del empleado a modificar: ");
            string cedula = Console.ReadLine();
            ClsEmpleado empleado = empleados.Find(e => e.Cedula == cedula);
            if (empleado != null)
            {
                Console.Write("Nuevo Nombre: ");
                empleado.Nombre = Console.ReadLine();
                Console.Write("Nueva Dirección: ");
                empleado.Direccion = Console.ReadLine();
                Console.Write("Nuevo Teléfono: ");
                empleado.Telefono = Console.ReadLine();
                Console.Write("Nuevo Salario: ");
                if (double.TryParse(Console.ReadLine(), out double salario))
                {
                    empleado.Salario = salario;
                    Console.WriteLine("Empleado modificado con éxito.");
                }
                else
                {
                    Console.WriteLine("Salario no válido. No se pudo modificar el empleado.");
                }
            }
            else
            {
                Console.WriteLine("Empleado no encontrado. No se pudo modificar el empleado.");
            }
        }

        private void BorrarEmpleado()
        {
            Console.Write("Ingrese la cédula del empleado a borrar: ");
            string cedula = Console.ReadLine();
            ClsEmpleado empleado = empleados.Find(e => e.Cedula == cedula);
            if (empleado != null)
            {
                empleados.Remove(empleado);
                Console.WriteLine("Empleado borrado con éxito.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado. No se pudo borrar el empleado.");
            }
        }

        private void InicializarArreglos()
        {
            empleados.Clear();
            Console.WriteLine("Arreglos de empleados inicializados.");
        }

        private void MostrarReportes()
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenú de Reportes:");
                Console.WriteLine("1. Consultar empleados con número de cédula");
                Console.WriteLine("2. Listar todos los empleados ordenados por nombre");
                Console.WriteLine("3. Calcular y mostrar el promedio de los salarios");
                Console.WriteLine("4. Calcular y mostrar el salario más alto y el más bajo");
                Console.WriteLine("5. Volver al Menú Principal");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            ConsultarEmpleadosPorCedula();
                            break;
                        case 2:
                            ListarEmpleadosOrdenadosPorNombre();
                            break;
                        case 3:
                            CalcularPromedioSalarios();
                            break;
                        case 4:
                            CalcularSalarioMaximoMinimo();
                            break;
                        case 5:
                            Console.WriteLine("Regresando al Menú Principal.");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida.Ingrese una opción valida.");
                }
            } while (opcion != 5);
        }

        private void ConsultarEmpleadosPorCedula()
        {
            Console.Write("Ingrese la cédula del empleado a consultar: ");
            string cedula = Console.ReadLine();
            ClsEmpleado empleado = empleados.Find(e => e.Cedula == cedula);
            if (empleado != null)
            {
                Console.WriteLine($"Cédula: {empleado.Cedula}");
                Console.WriteLine($"Nombre: {empleado.Nombre}");
                Console.WriteLine($"Dirección: {empleado.Direccion}");
                Console.WriteLine($"Teléfono: {empleado.Telefono}");
                Console.WriteLine($"Salario: {empleado.Salario}");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        private void ListarEmpleadosOrdenadosPorNombre()
        {
            empleados.Sort((e1, e2) => e1.Nombre.CompareTo(e2.Nombre)); //sort funcion que ordena nombres
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"Nombre: {empleado.Nombre}, Cédula: {empleado.Cedula}");
            }
        }

        private void CalcularPromedioSalarios()
        {
            if (empleados.Count > 0)
            {
                double totalSalarios = empleados.Sum(e => e.Salario);
                double promedio = totalSalarios / empleados.Count;
                Console.WriteLine($"Promedio de salarios: {promedio}");
            }
            else
            {
                Console.WriteLine("No hay empleados registrados para calcular el promedio de salarios.");
            }
        }

        private void CalcularSalarioMaximoMinimo()
        {
            if (empleados.Count > 0)
            {
                double salarioMaximo = empleados.Max(e => e.Salario); //Max funcion de maximo salario
                double salarioMinimo = empleados.Min(e => e.Salario); //Min funcion de minimo salario
                Console.WriteLine($"Salario más alto: {salarioMaximo}");
                Console.WriteLine($"Salario más bajo: {salarioMinimo}");
            }
            else
            {
                Console.WriteLine("No hay empleados registrados para calcular los salarios más alto y más bajo.");
            }
        }
        //Profe hice todos los metodos aquí en menú porque en empleados me daba error pero aquí
        //si me salió bien
    }
}
