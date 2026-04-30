namespace Clase_ICDIA_Unidad3.Runners
{
    using Clase_ICDIA_Unidad3.Programas;

    /// <summary>
    /// Runner que permite registrar música de forma interactiva.
    /// Presenta un menú para que el usuario registre canciones en un archivo CSV.
    /// </summary>
    public class Runner05_RegistroMusica
    {
        /// <summary>
        /// Constructor que ejecuta el menú de registro de música.
        /// Permite al usuario registrar canciones con sus características.
        /// </summary>
        public Runner05_RegistroMusica()
        {
            try
            {
                int opcion = 0;
                do
                {
                    try
                    {
                        Console.WriteLine("ingresa el numero de la seccion deseada");
                        Console.WriteLine("1: registro cancion");
                        Console.WriteLine("0: salir");
                        
                        if (!int.TryParse(Console.ReadLine(), out opcion))
                        {
                            Console.WriteLine("Error: Ingresa un número válido");
                            continue;
                        }
                        
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("ingresa el titulo de la cancion");
                                string titulo = Console.ReadLine();
                                Console.WriteLine("ingresa el artista");
                                string artista = Console.ReadLine();
                                Console.WriteLine("ingresa el genero musical");
                                string genero = Console.ReadLine();
                                Console.WriteLine("ingresa el año de lanzamiento");
                                
                                if (!int.TryParse(Console.ReadLine(), out int anio))
                                {
                                    Console.WriteLine("Error: Año debe ser un número");
                                    continue;
                                }
                                
                                Console.WriteLine("ingresa la duracion en minutos (ej. 3.5)");
                                if (!double.TryParse(Console.ReadLine(), out double duracion))
                                {
                                    Console.WriteLine("Error: Duración debe ser un número");
                                    continue;
                                }

                                Musica cancion = new Musica(titulo, artista, genero, anio, duracion);

                                StreamWriter sw = new StreamWriter("registro_musica.csv", true);
                                try
                                {
                                    sw.WriteLine(cancion.Titulo + "," + cancion.Artista + "," + cancion.Genero + "," + cancion.AnioLanzamiento + "," + cancion.DuracionMinutos);
                                    sw.Flush();
                                    Console.WriteLine("Canción registrada exitosamente");
                                }
                                finally
                                {
                                    sw.Close();
                                }
                                break;
                            case 0:
                                Console.WriteLine("gracias por usar el programa");
                                break;
                            default:
                                Console.WriteLine("Opción inválida");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error en el menú: {ex.Message}");
                    }
                } while (opcion != 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en Runner05: {ex.Message}");
            }
        }
    }
}