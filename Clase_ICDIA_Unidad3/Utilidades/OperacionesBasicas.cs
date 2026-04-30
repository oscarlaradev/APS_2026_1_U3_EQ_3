namespace Clase_ICDIA_Unidad3.Utilidades;

/// <summary>
/// Clase estática que proporciona operaciones matemáticas básicas.
/// Incluye constantes y métodos para realizar cálculos fundamentales.
/// </summary>
public static class OperacionesBasicas
{
    /// <summary>
    /// Constante que define el índice de reprobación del sistema.
    /// </summary>
    public const double Indice_Reprobacion = 0.001;
    
    /// <summary>
    /// Realiza la suma de dos números enteros.
    /// </summary>
    /// <param name="a">Primer número entero</param>
    /// <param name="b">Segundo número entero</param>
    /// <returns>La suma de a y b</returns>
    public static int Suma(int a, int b)
    {
        try
        {
            return a + b;
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Error de desbordamiento en suma: {ex.Message}");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al sumar: {ex.Message}");
            throw;
        }
    }

    /// <summary>
    /// Realiza la multiplicación de dos números enteros.
    /// </summary>
    /// <param name="a">Primer número entero</param>
    /// <param name="b">Segundo número entero</param>
    /// <returns>El producto de a y b</returns>
    public static int Multiplicacion(int a, int b)
    {
        try
        {
            return a * b;
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Error de desbordamiento en multiplicación: {ex.Message}");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al multiplicar: {ex.Message}");
            throw;
        }
    }
}