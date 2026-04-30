using Clase_ICDIA_Unidad3.Programas;

namespace Clase_ICDIA_Unidad3.Runners;

/// <summary>
/// Runner que demuestra el uso de excepciones personalizadas.
/// Utiliza las clases MatriculaException y NameFormatException.
/// </summary>
public class RunnerExcepcionesPersonalizadas
{
    /// <summary>
    /// Constructor que prueba las excepciones personalizadas.
    /// Intenta establecer una matricula invalida para generar una excepcion.
    /// </summary>
    public RunnerExcepcionesPersonalizadas()
    {
        try
        {
            Alumno al = new Alumno();
            long matricula = 100;
            al.Matricula = matricula;
            
            Console.WriteLine($"Alumno creado: {al}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Excepcion de argumento: {ex.Message}");
        }
        catch (MatriculaException ex)
        {
            Console.WriteLine($"Excepcion de matricula: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error general: {ex.Message}");
        }
    }
}