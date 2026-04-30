using Clase_ICDIA_Unidad3.Programas;

namespace Clase_ICDIA_Unidad3.Runners;

/// <summary>
/// Runner que demuestra el uso de la clase Score para gestionar puntuaciones.
/// Establece y modifica la puntuación global del sistema.
/// </summary>
public class RunnerAlumnoPuntuacion
{
    /// <summary>
    /// Constructor que ejecuta operaciones con la clase Score.
    /// Demuestra establecer, obtener y modificar puntuaciones.
    /// </summary>
    public RunnerAlumnoPuntuacion()
    {
        try
        {
            Score.Puntuacion = 10;
            Console.WriteLine($"Puntuacion inicial: {Score.Puntuacion.ToString()}");
            
            Score.Puntuacion += 15;
            Console.WriteLine($"Puntuacion despues de sumar 15: {Score.Puntuacion.ToString()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en RunnerAlumnoPuntuacion: {ex.Message}");
        }
    }
}