namespace Clase_ICDIA_Unidad3.Programas;

/// <summary>
/// Excepción personalizada que se lanza cuando hay errores relacionados con la matrícula.
/// Hereda de Exception y se utiliza para validaciones de matríscriculaduras inválidas.
/// </summary>
public class MatriculaException : Exception
{
    /// <summary>
    /// Constructor que crea una nueva instancia de MatriculaException con un mensaje de error.
    /// </summary>
    /// <param name="message">Mensaje de error descriptivo</param>
    public MatriculaException(string message) : base(message)
    {
        try
        {
            //Guardar en la base de datos que ocurrió este error
            Console.WriteLine($"[MATRÍCULA ERROR] {message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al registrar excepción de matrícula: {ex.Message}");
        }
    }
}