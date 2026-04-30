namespace Clase_ICDIA_Unidad3.Programas;

/// <summary>
/// Clase que representa un cuadrado y extiende la clase Poligono.
/// Hereda de Poligono e implementa el cálculo de área para un cuadrado.
/// </summary>
public class Cuadrado : Poligono
{
    /// <summary>
    /// Calcula el área de un cuadrado.
    /// Requiere un único parámetro que representa el lado del cuadrado.
    /// </summary>
    /// <param name="parametros">Array con un elemento que representa el lado del cuadrado</param>
    /// <returns>El área del cuadrado</returns>
    /// <exception cref="ArgumentException">Se lanza si no se proporciona el parámetro requerido</exception>
    public override int CalcularArea(int[] parametros)
    {
        try
        {
            if (parametros == null)
                throw new ArgumentNullException(nameof(parametros));
                
            if (parametros.Length < 1)
                throw new ArgumentException("Se requiere un parámetro para calcular el área del cuadrado");
            
            if (parametros[0] <= 0)
                throw new ArgumentException("El lado debe ser un valor positivo");
            
            return parametros[0] * parametros[0];
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Error: Parámetros nulos - {ex.Message}");
            throw;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error al calcular área del cuadrado: {ex.Message}");
            throw;
        }
    }
}