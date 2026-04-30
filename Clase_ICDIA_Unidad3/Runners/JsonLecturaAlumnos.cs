using System.Text.Json;
using Clase_ICDIA_Unidad3.Programas;


namespace Clase_ICDIA_Unidad3.Runners;

/// <summary>
/// Runner que deserializa alumnos desde un archivo JSON.
/// Lee el archivo alumnos.json y carga los alumnos en una lista.
/// </summary>
public class JsonLecturaAlumnos
{
    /// <summary>
    /// Constructor que ejecuta la deserialización de alumnos desde archivo JSON.
    /// </summary>
    public JsonLecturaAlumnos()
    {
        try
        {
            List<Alumno> alumnos = new List<Alumno>();
            Alumno temporal;

            try
            {
                foreach (string linea in File.ReadLines("alumnos.json"))
                {
                    try
                    {
                        temporal = JsonSerializer.Deserialize<Alumno>(linea);
                        if (temporal != null)
                        {
                            alumnos.Add(temporal);
                        }
                    }
                    catch (JsonException ex)
                    {
                        Console.WriteLine($"Error al deserializar linea: {ex.Message}");
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Archivo no encontrado: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de entrada/salida: {ex.Message}");
            }
            
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en JsonLecturaAlumnos: {ex.Message}");
        }
    }
}