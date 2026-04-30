namespace Clase_ICDIA_Unidad3.Runners
{
    using Clase_ICDIA_Unidad3.Programas;

    /// <summary>
    /// Runner que permite registrar mascotas de forma interactiva.
    /// Presenta un menú para que el usuario registre mascotas en un archivo CSV.
    /// </summary>
    public class Runner04_RegistroMascotas
    {
        /// <summary>
        /// Constructor que ejecuta el menú de registro de mascotas.
        /// Permite al usuario registrar mascotas con sus características.
        /// </summary>
        public Runner04_RegistroMascotas()
        {
            try
            {
                int opcion = 0;
                do
                {
                    try
                    {
                        Console.WriteLine("ingresa el numero de la seccion deseada");
                        Console.WriteLine("1: registro mascota");
                        Console.WriteLine("0: salir");
                        
                        if (!int.TryParse(Console.ReadLine(), out opcion))
                        {
                            Console.WriteLine("Error: Ingresa un número válido");
                            continue;
                        }
                        
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("ingresa el nombre de la mascota");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("ingresa la especie (ej. Perro, Gato)");
                                string especie = Console.ReadLine();
                                Console.WriteLine("ingresa la raza");
                                string raza = Console.ReadLine();
                                Console.WriteLine("ingresa la edad");
                                
                                if (!int.TryParse(Console.ReadLine(), out int edad))
                                {
                                    Console.WriteLine("Error: Edad debe ser un número");
                                    continue;
                                }
                                
                                Console.WriteLine("ingresa el peso en kg");
                                if (!double.TryParse(Console.ReadLine(), out double peso))
                                {
                                    Console.WriteLine("Error: Peso debe ser un número");
                                    continue;
                                }

                                Mascota mascota = new Mascota(nombre, especie, raza, edad, peso);

                                StreamWriter sw = new StreamWriter("registro_mascotas.csv", true);
                                try
                                {
                                    sw.WriteLine(mascota.Nombre + "," + mascota.Especie + "," + mascota.Raza + "," + mascota.Edad + "," + mascota.Peso);
                                    sw.Flush();
                                    Console.WriteLine("Mascota registrada exitosamente");
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
                Console.WriteLine($"Error en Runner04: {ex.Message}");
            }
        }
    }
}