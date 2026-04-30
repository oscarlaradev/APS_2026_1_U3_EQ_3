using System.Text.Json;
using Clase_ICDIA_Unidad3.Programas;

namespace Clase_ICDIA_Unidad3.Runners;

/// <summary>
/// Runner que serializa alumnos a un archivo JSON.
/// Crea tres alumnos y los guarda en formato JSON.
/// </summary>
public class JsonArchivoAlumnos
{
    /// <summary>
    /// Constructor que ejecuta la serialización de alumnos a archivo JSON.
    /// </summary>
    public JsonArchivoAlumnos()
    {
        try
        {
            Alumno al1 = new Alumno("oscar", 1, 10);
            Alumno al2 = new Alumno("luna", 2, 10);
            Alumno al3 = new Alumno("fernando", 3, 9);
            
            StreamWriter sw = new StreamWriter("alumnos.json");
            try
            {
                string json = JsonSerializer.Serialize(al1);
                sw.WriteLine(json);
                
                json = JsonSerializer.Serialize(al2);
                sw.WriteLine(json);
                
                json = JsonSerializer.Serialize(al3);
                sw.WriteLine(json);
                
                sw.Flush();
                Console.WriteLine("Alumnos serializados exitosamente en alumnos.json");
            }
            finally
            {
                sw.Close();
            }
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Error en serialización JSON: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error de entrada/salida: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en JsonArchivoAlumnos: {ex.Message}");
        }
    }
}