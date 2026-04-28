namespace Clase_ICDIA_Unidad3.Programas;

public class Triangulo :Poligono
{
    public override int CalcularArea(int[] parametros)
    {
        if (parametros.Length < 2)
        {
            throw new ArgumentException("se ocupan dos parametros");
        }
        return parametros[0] * parametros[1];
    }
}