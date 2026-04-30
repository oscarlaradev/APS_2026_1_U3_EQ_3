namespace Clase_ICDIA_Unidad3.Programas;

/// <summary>
/// Clase estática que gestiona la puntuación global del sistema.
/// Proporciona métodos estáticos para obtener y establecer la puntuación.
/// </summary>
public class Score
{
    /// <summary>
    /// Almacena la puntuación global
    /// </summary>
    private static int puntuacion;
    
    /// <summary>
    /// Propiedad estática que obtiene o establece la puntuación global.
    /// </summary>
    public static int Puntuacion 
    { 
        get
        {
            try
            {
                return puntuacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener puntuación: {ex.Message}");
                return 0;
            }
        }
        set
        {
            try
            {
                if (value < 0)
                    throw new ArgumentException("La puntuación no puede ser negativa");
                puntuacion = value;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error al establecer puntuación: {ex.Message}");
            }
        }
    }
}