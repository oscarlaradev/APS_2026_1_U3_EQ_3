namespace Clase_ICDIA_Unidad3.Programas;

/// <summary>
/// Excepción personalizada que se lanza cuando hay errores de formato en el nombre.
/// Hereda de Exception y se utiliza para errores de validación del nombre de alumnos.
/// </summary>
public class NameFormatException : Exception
{
    /// <summary>
    /// Constructor que crea una nueva instancia de NameFormatException con un mensaje de error.
    /// </summary>
    /// <param name="message">Mensaje de error descriptivo</param>
    public NameFormatException(string message) : base(message)
    {
        try
        {
            Console.WriteLine($"[FORMATO NOMBRE ERROR] {message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al registrar excepción de formato: {ex.Message}");
        }
    }
}