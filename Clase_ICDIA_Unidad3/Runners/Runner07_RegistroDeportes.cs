namespace Clase_ICDIA_Unidad3.Runners
{
    using Clase_ICDIA_Unidad3.Programas;

    /// <summary>
    /// Runner que permite registrar deportes de forma interactiva.
    /// </summary>
    public class Runner07_RegistroDeportes
    {
        /// <summary>
        /// Constructor que ejecuta el menu de registro de deportes.
        /// </summary>
        public Runner07_RegistroDeportes()
        {
            try
            {
                int opcion = 0;
                do
                {
                    try
                    {
                        Console.WriteLine("ingresa el numero de la seccion deseada");
                        Console.WriteLine("1: registro deporte");
                        Console.WriteLine("0: salir");
                        if (!int.TryParse(Console.ReadLine(), out opcion))
                        {
                            Console.WriteLine("Error: Ingresa un numero valido");
                            continue;
                        }
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("ingresa el nombre del deporte");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("ingresa el tipo -ej. Equipo, Individual-");
                                string tipo = Console.ReadLine();
                                Console.WriteLine("ingresa el numero de jugadores por lado");
                                if (!int.TryParse(Console.ReadLine(), out int jugadores))
                                {
                                    Console.WriteLine("Error: Numero de jugadores debe ser un numero");
                                    continue;
                                }
                                Console.WriteLine("es un deporte olimpico? (true/false)");
                                if (!bool.TryParse(Console.ReadLine(), out bool olimpico))
                                {
                                    Console.WriteLine("Error: Ingresa true o false");
                                    continue;
                                }
                                Console.WriteLine("ingresa la duracion promedio de un partido/evento en minutos");
                                if (!double.TryParse(Console.ReadLine(), out double duracion))
                                {
                                    Console.WriteLine("Error: Duracion debe ser un numero");
                                    continue;
                                }
                                Deporte deporte = new Deporte(nombre, tipo, jugadores, olimpico, duracion);
                                StreamWriter sw = new StreamWriter("registro_deportes.csv", true);
                                try
                                {
                                    sw.WriteLine(deporte.Nombre + "," + deporte.Tipo + "," + deporte.NumeroJugadores + "," + deporte.EsOlimpico + "," + deporte.DuracionPromedioMinutos);
                                    sw.Flush();
                                    Console.WriteLine("Deporte registrado exitosamente");
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
                                Console.WriteLine("Opcion invalida");
                                break;
                        }
            } while (opcion != 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en el menu: {ex.Message}");
            }
        }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en Runner07: {ex.Message}");
        }
    }
}