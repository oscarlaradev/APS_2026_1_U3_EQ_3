namespace Clase_ICDIA_Unidad3.Utilidades;

/// <summary>
/// Clase que proporciona métodos estáticos y de instancia para leer archivos.
/// Incluye diferentes versiones de métodos de lectura.
/// </summary>
public class LeerArchivos
{
    /// <summary>
    /// Constructor por defecto que inicializa una nueva instancia de LeerArchivos.
    /// </summary>
    public LeerArchivos()
    {
        try
        {
            Console.WriteLine("Instancia de LeerArchivos creada");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al crear instancia de LeerArchivos: {ex.Message}");
        }
    }

    /// <summary>
    /// Método estático que lee un archivo e imprime un mensaje en consola.
    /// Esta es la versión básica del método Leer.
    /// </summary>
    public static void Leer()
    {
        try
        {
            Console.WriteLine("Archivo Leído");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al leer archivo: {ex.Message}");
        }
    }

    /// <summary>
    /// Método de instancia que lee un archivo con funcionalidad mejorada.
    /// Esta es la versión 2.0 con más capacidades.
    /// </summary>
    public void LeerV2()
    {
        try
        {
            Console.WriteLine("Archivo Leído 2.0");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al leer archivo v2.0: {ex.Message}");
        }
    }
}