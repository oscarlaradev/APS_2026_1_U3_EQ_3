namespace Clase_ICDIA_Unidad3.Programas;

public abstract class Poligono
{
    private string nombre;

    public int CalcularPerimetro(int lado, int longitud)
    {
        return lado * longitud;   
    }

    public abstract int CalcularArea(int[] parametros);
}