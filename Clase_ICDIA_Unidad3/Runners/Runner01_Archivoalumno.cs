using Clase_ICDIA_Unidad3.Programas;

namespace Clase_ICDIA_Unidad3.Runners;

/// <summary>
/// Runner que registra alumnos en un archivo CSV.
/// Crea tres alumnos y los guarda en el archivo "alumnos.csv".
/// </summary>
public class Runner01_Archivoalumno
{
    /// <summary>
    /// Constructor que ejecuta el registro de alumnos en archivo.
    /// Crea instancias de alumnos y las escribe en formato CSV.
    /// </summary>
    public Runner01_Archivoalumno()
    {
        try
        {
            Alumno al1 = new Alumno("juan perez", 1);
            Alumno al2 = new Alumno("juan sanchez", 2);
            Alumno al3 = new Alumno("juan segundo", 3);
            
            StreamWriter sw = new StreamWriter("alumnos.csv", true);
            try
            {
                sw.WriteLine(al1.Matricula + "," + al1.Nombre);
                sw.WriteLine(al2.Matricula + "," + al2.Nombre);
                sw.WriteLine(al3.Matricula + "," + al3.Nombre);
                
                sw.Flush();
                Console.WriteLine("Alumnos registrados exitosamente en alumnos.csv");
            }
            finally
            {
                sw.Close();
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error de validación: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error al escribir archivo: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en Runner01: {ex.Message}");
        }
    }
}