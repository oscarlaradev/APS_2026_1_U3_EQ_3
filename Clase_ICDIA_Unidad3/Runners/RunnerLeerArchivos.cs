using Clase_ICDIA_Unidad3.Utilidades;

namespace Clase_ICDIA_Unidad3.Runners;

/// <summary>
/// Runner que demuestra la lectura de archivos.
/// Utiliza la clase LeerArchivos para ejecutar metodos de lectura.
/// </summary>
public class RunnerLeerArchivos
{
    /// <summary>
    /// Constructor que ejecuta las operaciones de lectura de archivos.
    /// </summary>
    public RunnerLeerArchivos()
    {
        try
        {
            LeerArchivos.Leer();

            LeerArchivos archivo;
            archivo = new LeerArchivos();
            archivo.LeerV2();
            
            Console.WriteLine("Lectura de archivos completada exitosamente");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en RunnerLeerArchivos: {ex.Message}");
        }
    }
}
