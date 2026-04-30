using Clase_ICDIA_Unidad3.Programas;

namespace Clase_ICDIA_Unidad3.Runners;

/// <summary>
/// Runner que permite registrar alumnos de forma interactiva.
/// Presenta un menú para que el usuario registre alumnos en un archivo CSV.
/// </summary>
public class Runner02_RegistroAlumnos
{
    /// <summary>
    /// Constructor que ejecuta el menú de registro de alumnos.
    /// Permite al usuario registrar alumnos y guardarlos en archivo.
    /// </summary>
    public Runner02_RegistroAlumnos()
    {
        try
        {
            int opcion = 0;
            int alumnosRegistrados = 0;
            do
            {
                try
                {
                    Console.WriteLine("ingresa el numero de la seccion deseada");
                    Console.WriteLine("1:registro alumno");
                    Console.WriteLine("0: salir");
                    
                    string inputOpcion = Console.ReadLine();
                    if (!int.TryParse(inputOpcion, out opcion))
                    {
                        Console.WriteLine("Error: Ingresa un número válido");
                        continue;
                    }
                    
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("ingresa el nombre del alumno");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("ingresa la matricula del alumno");
                            
                            if (!long.TryParse(Console.ReadLine(), out long matricula))
                            {
                                Console.WriteLine("Error: Matrícula debe ser un número");
                                continue;
                            }
                            
                            Alumno alumno = new Alumno(nombre, matricula);
                            
                            StreamWriter sw = new StreamWriter("registro.csv", true);
                            try
                            {
                                sw.WriteLine(alumno.Matricula + "," + alumno.Nombre);
                                sw.Flush();
                                alumnosRegistrados++;
                                Console.WriteLine("Alumno registrado exitosamente");
                            }
                            finally
                            {
                                sw.Close();
                            }
                            break;
                        case 0:
                            Console.WriteLine("gracias por usar el programa");
                            break;
                        default:
                            Console.WriteLine("Opción inválida");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error en el menú: {ex.Message}");
                }
            } while (opcion != 0);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en Runner02: {ex.Message}");
        }
    }
}