namespace Clase_ICDIA_Unidad3.Programas;

/// <summary>
/// Esta clase sirve para realizar operaciones con poligonos 
/// </summary>
public abstract class Poligono
{
    //Comentario de una linea
    
    /*
     * Comentario multiple
     */
    
    /// <summary>
    /// 
    /// </summary>
    private string nombre;
    
    /// <summary>
    /// Calcula el perimetro de un poligono
    /// </summary>
    /// <param name="lado">Cantidad de lados</param>
    /// <param name="longitud">Largo de cada lado</param>
    /// <returns></returns>
    public int CalcularPerimetro(int lado, int longitud)
    {
        return lado * longitud;   
    }
    
    /// <summary>
    /// Calcula el ara de un poligono
    /// </summary>
    /// <param name="parametros">TEXTOOOOOO</param>
    /// <returns></returns>
    public abstract int CalcularArea(int[] parametros);
}