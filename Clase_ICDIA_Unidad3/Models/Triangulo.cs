namespace Clase_ICDIA_Unidad3.Programas;

/// <summary>
/// Clase que representa un triángulo y extiende la clase Poligono.
/// Hereda de Poligono e implementa el cálculo de área para un triángulo.
/// </summary>
public class Triangulo : Poligono
{
    /// <summary>
    /// Calcula el área de un triángulo usando la fórmula: (base * altura) / 2.
    /// Requiere dos parámetros: base y altura.
    /// </summary>
    /// <param name="parametros">Array con dos elementos: parametros[0] = base, parametros[1] = altura</param>
    /// <returns>El área del triángulo</returns>
    /// <exception cref="ArgumentException">Se lanza si no se proporcionan los dos parámetros requeridos</exception>
    public override int CalcularArea(int[] parametros)
    {
        try
        {
            if (parametros == null)
                throw new ArgumentNullException(nameof(parametros));
            
            if (parametros.Length < 2)
                throw new ArgumentException("Se ocupan dos parámetros para calcular el área del triángulo (base y altura)");
            
            if (parametros[0] <= 0)
                throw new ArgumentException("La base debe ser un valor positivo");
            
            if (parametros[1] <= 0)
                throw new ArgumentException("La altura debe ser un valor positivo");
            
            return (parametros[0] * parametros[1]) / 2;
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Error: Parámetros nulos - {ex.Message}");
            throw;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error al calcular área del triángulo: {ex.Message}");
            throw;
        }
    }
}