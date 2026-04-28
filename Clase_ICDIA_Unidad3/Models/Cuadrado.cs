namespace Clase_ICDIA_Unidad3.Programas;

public class Cuadrado : Poligono
{
    public override int CalcularArea(int[] parametros)
    {
        if (parametros.Length < 1)
        {
            throw new ArgumentException("se requiere un parametro");
        }
        return parametros[0] * parametros[0];
    }
}