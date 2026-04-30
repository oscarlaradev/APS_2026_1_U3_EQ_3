namespace Clase_ICDIA_Unidad3.Programas;

/// <summary>
/// Clase abstracta que sirve para realizar operaciones con polígonos.
/// Define métodos para calcular perímetro y área.
/// </summary>
public abstract class Poligono
{
    /// <summary>
    /// Nombre del polígono
    /// </summary>
    private string nombre;
    
    /// <summary>
    /// Calcula el perímetro de un polígono.
    /// </summary>
    /// <param name="lado">Cantidad de lados</param>
    /// <param name="longitud">Largo de cada lado</param>
    /// <returns>El perímetro calculado</returns>
    public int CalcularPerimetro(int lado, int longitud)
    {
        try
        {
            if (lado <= 0)
                throw new ArgumentException("La cantidad de lados debe ser positiva");
            if (longitud <= 0)
                throw new ArgumentException("La longitud debe ser positiva");
                
            return lado * longitud;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error al calcular perímetro: {ex.Message}");
            throw;
        }
    }
    
    /// <summary>
    /// Calcula el área de un polígono.
    /// Este método debe ser implementado por las clases derivadas.
    /// </summary>
    /// <param name="parametros">Parámetros necesarios para calcular el área según el tipo de polígono</param>
    /// <returns>El área del polígono</returns>
    public abstract int CalcularArea(int[] parametros);
}