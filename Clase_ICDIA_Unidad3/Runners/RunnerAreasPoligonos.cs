using Clase_ICDIA_Unidad3.Programas;

namespace Clase_ICDIA_Unidad3.Runners;

public class RunnerAreasPoligonos
{
    public RunnerAreasPoligonos()
    {
        Poligono poligono;
        //= new Poligono();
        
        poligono = new Triangulo();
        //poligono.
        
        //poligono.
        
        Triangulo triangulo = new Triangulo();
        //triangulo.CalcArea()

        double a = triangulo.CalcularPerimetro(5, 7);

        a = triangulo.CalcularArea(new int[] { 3, 6 });

        Console.WriteLine(a);
    }
}