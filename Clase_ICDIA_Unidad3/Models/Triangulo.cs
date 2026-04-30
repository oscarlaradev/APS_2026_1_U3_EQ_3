namespace Clase_ICDIA_Unidad3.Programas;

public class Triangulo :Poligono
{
    /// <summary>
    /// PPP. Param 1 = Base, Param 2 =  Altura
    /// </summary>
    /// <param name="parametros"> Se espera dos parametros, el primer asociado a la base y
    /// El segundo a la altura del triángulo
    /// </param>
    /// <returns> Devuelve el area del poligono</returns>
    /// <exception cref="ArgumentException"></exception>
    public override int CalcularArea(int[] parametros)
    {
        if (parametros.Length < 2)
        {
            throw new ArgumentException("se ocupan dos parametros");
        }
        return (parametros[0] * parametros[1])/2;
    }
}