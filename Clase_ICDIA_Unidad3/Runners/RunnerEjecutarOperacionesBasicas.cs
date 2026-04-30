using Clase_ICDIA_Unidad3.Utilidades;

namespace Clase_ICDIA_Unidad3.Runners;

/// <summary>
/// Runner que demuestra el uso de operaciones basicas.
/// Ejecuta operaciones de suma y multiplicacion usando la clase OperacionesBasicas.
/// </summary>
public class RunnerEjecutarOperacionesBasicas
{
    /// <summary>
    /// Constructor que ejecuta operaciones basicas aritmeticas.
    /// </summary>
    public RunnerEjecutarOperacionesBasicas()
    {
        try
        {
            OperacionesBasicas.Suma(2, 4);
            
            int resultado = OperacionesBasicas.Multiplicacion(2, 4);
            double IndiceR = OperacionesBasicas.Indice_Reprobacion;
            
            Console.WriteLine($"Resultado de multiplicacion: {resultado}");
            Console.WriteLine($"Indice de reprobacion: {IndiceR}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en RunnerEjecutarOperacionesBasicas: {ex.Message}");
        }
    }
}