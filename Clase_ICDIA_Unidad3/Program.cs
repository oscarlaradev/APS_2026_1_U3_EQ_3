using Clase_ICDIA_Unidad3.Runners;

namespace Clase_ICDIA_Unidad3;

class Program
{
    static void Main(string[] args)
    {
        
        
        int n = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("1: Registro Alumno (Archivo)");
            Console.WriteLine("2: Registro Alumnos (Runner)");
            Console.WriteLine("3: Registro de Comidas");
            Console.WriteLine("4: Registro de Mascotas");
            Console.WriteLine("5: Registro de Música");
            Console.WriteLine("6: Registro de Pasatiempos");
            Console.WriteLine("7: Registro de Deportes");
            Console.WriteLine("8: Registro Alumnos(2)");
            Console.WriteLine("0: Salir");
            
            Console.WriteLine("Selecciona el programa deseado");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    new Runner01_Archivoalumno();
                    break;
                case 2:
                    new Runner02_RegistroAlumnos();
                    break;
                case 3:
                    new Runner03_RegistroComidas();
                    break;
                case 4:
                    new Runner04_RegistroMascotas();
                    break;
                case 5:
                    new Runner05_RegistroMusica();
                    break;
                case 6:
                    new Runner06_RegistroPasatiempos();
                    break;
                case 7:
                    new Runner07_RegistroDeportes();
                    break;
                case 8:
                    new Runner08_RegistroAlumnos();
                    break;
                case 0 :
                    Console.WriteLine("Saliendo del programa................");
                    break;
                default:
                    Console.WriteLine("No se ha encontrado el programa");
                    break;
            }
            if (n != 0)
            {
                Console.WriteLine("\nPresiona una tecla para volver al menú.................");
                Console.ReadKey();
            }
        } while (n != 0);
        
    }
}