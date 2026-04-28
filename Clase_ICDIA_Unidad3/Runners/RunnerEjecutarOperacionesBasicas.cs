using Clase_ICDIA_Unidad3.Utilidades;

namespace Clase_ICDIA_Unidad3.Runners;

public class RunnerEjecutarOperacionesBasicas
{
    public RunnerEjecutarOperacionesBasicas()
    {
        OperacionesBasicas.Suma(2,4);
        
        //int resultado = OperacionesBasicas.Suma(2,4);
        int resultado = OperacionesBasicas.multiplicacion(2,4);
        double IndiceR = OperacionesBasicas.Indice_Reprobacion;
        
        Console.WriteLine($"Resultado : {resultado}");
    }
}