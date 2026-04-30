namespace Clase_ICDIA_Unidad3.Programas;

public class Cuadrado : Poligono
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="parametros">Se espera un único parámetro
    /// asociado al lado del cuadrado</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public override int CalcularArea(int[] parametros)
    {
        if (parametros.Length < 1)
        {
            throw new ArgumentException("se requiere un parametro");
        }
        return parametros[0] * parametros[0];
    }
}