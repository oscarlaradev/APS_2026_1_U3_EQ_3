using Clase_ICDIA_Unidad3.Programas;

namespace Clase_ICDIA_Unidad3.Runners;

/// <summary>
/// Runner que demuestra el calculo de areas y perimetros de poligonos.
/// Utiliza las clases Triangulo para realizar calculos geometricos.
/// </summary>
public class RunnerAreasPoligonos
{
    /// <summary>
    /// Constructor que ejecuta calculos de areas y perimetros.
    /// Crea instances de poligonos y calcula sus dimensiones.
    /// </summary>
    public RunnerAreasPoligonos()
    {
        try
        {
            Poligono poligono;
            poligono = new Triangulo();
            
            Triangulo triangulo = new Triangulo();

            try
            {
                double perimetro = triangulo.CalcularPerimetro(5, 7);
                Console.WriteLine($"Perimetro del triangulo: {perimetro}");
                
                int area = triangulo.CalcularArea(new int[] { 3, 6 });
                Console.WriteLine($"Area del triangulo: {area}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error en calculo: {ex.Message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en RunnerAreasPoligonos: {ex.Message}");
        }
    }
}