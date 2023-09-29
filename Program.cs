using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioDeEstudiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Calculadora de Promedio Final***");
            Console.WriteLine(" ");

            bool continuar = true;

            while (continuar)
            {
                Console.Write("Ingrese el número de estudiantes: ");
                int numEstudiantes = int.Parse(Console.ReadLine());

                double promedioTotal = 0; // Variable para mantener el promedio total de todos los estudiantes

                for (int i = 1; i <= numEstudiantes; i++)
                {
                    Console.WriteLine($"Estudiante #{i}");
                    Console.Write("Carnet: ");
                    string carnet = Console.ReadLine();
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese la nota del Quiz 1: ");
                    double quiz1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del Quiz 2: ");
                    double quiz2 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del Quiz 3: ");
                    double quiz3 = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese la nota de la Tarea 1: ");
                    double tarea1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota de la Tarea 2: ");
                    double tarea2 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota de la Tarea 3: ");
                    double tarea3 = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese la nota del Examen 1: ");
                    double examen1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del Examen 2: ");
                    double examen2 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del Examen 3: ");
                    double examen3 = double.Parse(Console.ReadLine());

                    // Ajustar las ponderaciones para que sumen 100%
                    double sumaPonderaciones = 25 + 30 + 45;
                    double factorQuices = 25 / sumaPonderaciones;
                    double factorTareas = 30 / sumaPonderaciones;
                    double factorExamenes = 45 / sumaPonderaciones;

                    // Calcular porcentajes
                    double porcentajeQuices = ((quiz1 + quiz2 + quiz3) / 3) * factorQuices;
                    double porcentajeTareas = ((tarea1 + tarea2 + tarea3) / 3) * factorTareas;
                    double porcentajeExamenes = ((examen1 + examen2 + examen3) / 3) * factorExamenes;

                    // Calcular promedio final
                    double promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

                    // Sumar al promedio total
                    promedioTotal += promedioFinal;

                    // Determinar la condición del estudiante
                    string condicion = "Reprobado";
                    if (promedioFinal >= 70)
                    {
                        condicion = "Aprobado";
                    }
                    else if (promedioFinal >= 50)
                    {
                        condicion = "Aplazado";
                    }

                    // Mostrar resultados
                    Console.WriteLine($"Carnet: {carnet}");
                    Console.WriteLine($"Nombre: {nombre}");
                    Console.WriteLine($"Porcentaje de Quices: {porcentajeQuices}%");
                    Console.WriteLine($"Porcentaje de Tareas: {porcentajeTareas}%");
                    Console.WriteLine($"Porcentaje de Examenes: {porcentajeExamenes}%");
                    Console.WriteLine($"Promedio Final: {promedioFinal}");
                    Console.WriteLine($"Condición: {condicion}");
                    Console.WriteLine();
                }

                // Calcular y mostrar el promedio total de todos los estudiantes
                double promedioTotalGeneral = promedioTotal / numEstudiantes;
                Console.WriteLine($"Promedio Total de Todos los Estudiantes: {promedioTotalGeneral}");

                Console.WriteLine("Presione Enter para continuar o ingrese '1' para salir:");
                string opcion = Console.ReadLine();

                if (opcion != "1")
                {
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }
            }
        }
    }
}
