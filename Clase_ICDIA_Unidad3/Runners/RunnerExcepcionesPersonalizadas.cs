using Clase_ICDIA_Unidad3.Programas;

namespace Clase_ICDIA_Unidad3.Runners;

public class RunnerExcepcionesPersonalizadas
{
    public RunnerExcepcionesPersonalizadas()
    {
        try
        {
            Alumno al = new Alumno();
            long matricula = 100;
            al.Matricula = matricula;
            
           // int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(al);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex);
            throw;
        }
        catch (MatriculaException ex)
        {
            Console.WriteLine(ex);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        
    }
}