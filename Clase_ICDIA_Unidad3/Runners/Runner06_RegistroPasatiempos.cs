namespace Clase_ICDIA_Unidad3.Runners
{
    using Clase_ICDIA_Unidad3.Programas;

    /// <summary>
    /// Runner que permite registrar pasatiempos de forma interactiva.
    /// </summary>
    public class Runner06_RegistroPasatiempos
    {
        /// <summary>
        /// Constructor que ejecuta el menu de registro de pasatiempos.
        /// </summary>
        public Runner06_RegistroPasatiempos()
        {
            try
            {
                int opcion = 0;
                do
                {
                    try
                    {
                        Console.WriteLine("ingresa el numero de la seccion deseada");
                        Console.WriteLine("1: registro pasatiempo");
                        Console.WriteLine("0: salir");
                        if (!int.TryParse(Console.ReadLine(), out opcion))
                        {
                            Console.WriteLine("Error: Ingresa un numero valido");
                            continue;
                        }
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("ingresa el nombre del pasatiempo");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("ingresa la descripcion");
                                string descripcion = Console.ReadLine();
                                Console.WriteLine("ingresa las horas que le dedicas a la semana");
                                if (!int.TryParse(Console.ReadLine(), out int horas))
                                {
                                    Console.WriteLine("Error: Horas debe ser un numero");
                                    continue;
                                }
                                Console.WriteLine("ingresa el costo mensual aproximado");
                                if (!double.TryParse(Console.ReadLine(), out double costo))
                                {
                                    Console.WriteLine("Error: Costo debe ser un numero");
                                    continue;
                                }
                                Console.WriteLine("requiere equipo especial?  true/false");
                                if (!bool.TryParse(Console.ReadLine(), out bool equipo))
                                {
                                    Console.WriteLine("Error: Ingresa true o false");
                                    continue;
                                }
                                Pasatiempo hobby = new Pasatiempo(nombre, descripcion, horas, costo, equipo);
                                StreamWriter sw = new StreamWriter("registro_pasatiempos.csv", true);
                                try
                                {
                                    sw.WriteLine(hobby.Nombre + "," + hobby.Descripcion + "," + hobby.HorasSemanales + "," + hobby.CostoMensual + "," + hobby.RequiereEquipo);
                                    sw.Flush();
                                    Console.WriteLine("Pasatiempo registrado exitosamente");
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
            Console.WriteLine($"Error en Runner06: {ex.Message}");
        }
    }
}