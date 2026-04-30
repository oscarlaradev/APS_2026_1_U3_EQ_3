namespace Clase_ICDIA_Unidad3.Runners
{
    using Clase_ICDIA_Unidad3.Programas;

    /// <summary>
    /// Runner que permite registrar comidas de forma interactiva.
    /// Presenta un menú para que el usuario registre comidas en un archivo CSV.
    /// </summary>
    public class Runner03_RegistroComidas
    {
        /// <summary>
        /// Constructor que ejecuta el menú de registro de comidas.
        /// Permite al usuario registrar comidas con sus características.
        /// </summary>
        public Runner03_RegistroComidas()
        {
            try
            {
                int opcion = 0;
                do
                {
                    try
                    {
                        Console.WriteLine("ingresa el numero de la seccion deseada");
                        Console.WriteLine("1: registro comida");
                        Console.WriteLine("0: salir");
                        
                        if (!int.TryParse(Console.ReadLine(), out opcion))
                        {
                            Console.WriteLine("Error: Ingresa un número válido");
                            continue;
                        }
                        
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("ingresa el nombre de la comida");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("ingresa la categoria (ej. Mexicana, Italiana)");
                                string categoria = Console.ReadLine();
                                Console.WriteLine("ingresa el precio");
                                
                                if (!double.TryParse(Console.ReadLine(), out double precio))
                                {
                                    Console.WriteLine("Error: Precio debe ser un número");
                                    continue;
                                }
                                
                                Console.WriteLine("ingresa las calorias");
                                if (!int.TryParse(Console.ReadLine(), out int calorias))
                                {
                                    Console.WriteLine("Error: Calorías debe ser un número");
                                    continue;
                                }
                                
                                Console.WriteLine("ingresa si es picante (true/false)");
                                if (!bool.TryParse(Console.ReadLine(), out bool esPicante))
                                {
                                    Console.WriteLine("Error: Ingresa true o false");
                                    continue;
                                }

                                Comida comida = new Comida(nombre, categoria, precio, calorias, esPicante);

                                StreamWriter sw = new StreamWriter("registro_comidas.csv", true);
                                try
                                {
                                    sw.WriteLine(comida.Nombre + "," + comida.Categoria + "," + comida.Precio + "," + comida.Calorias + "," + comida.EsPicante);
                                    sw.Flush();
                                    Console.WriteLine("Comida registrada exitosamente");
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
                Console.WriteLine($"Error en Runner03: {ex.Message}");
            }
        }
    }
}