using System.Text.Json;
using Clase_ICDIA_Unidad3.Programas;
namespace Clase_ICDIA_Unidad3.Runners;

/// <summary>
/// Runner que prueba serialización y deserialización JSON.
/// Crea un alumno, lo serializa a JSON, y lo deserializa nuevamente.
/// </summary>
public class JsonTest
{
    /// <summary>
    /// Constructor que ejecuta la prueba de JSON.
    /// Serializa y deserializa objetos Alumno usando JsonSerializer.
    /// </summary>
    public JsonTest()
    {
        try
        {
            Alumno alumno = new Alumno("juan", 4);
            alumno.Calificacion = 10;
            Console.WriteLine("Alumno original:");
            Console.WriteLine(alumno);
            
            Console.WriteLine();
            string alumno_json = JsonSerializer.Serialize(alumno);
            Console.WriteLine("JSON serializado:");
            Console.WriteLine(alumno_json);
            
            Console.WriteLine();
            Alumno alumno2 = JsonSerializer.Deserialize<Alumno>(alumno_json);
            Console.WriteLine("Alumno deserializado:");
            Console.WriteLine(alumno2);
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Error en serializacion JSON: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en JsonTest: {ex.Message}");
        }
    }
}