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
            Console.WriteLine("9: Registro Alumnos(eliminacion)(3)");
            Console.WriteLine("10: Registro Alumnos(guardar)(3)");
            Console.WriteLine("11: Json Test");
            Console.WriteLine("12: JsonArchivo");
            Console.WriteLine("13: JsonLectura");
            Console.WriteLine("14: ExcepcionesPersonalizadas");
            Console.WriteLine("15: Ejecutar OperacionesBasicas");
            Console.WriteLine("16: Areas Poligonos");
            Console.WriteLine("17: Aumno Puntuacion");
            Console.WriteLine("18: LeerArchivos");
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
                case 9:
                    new Runner09_RegistroAlumnos();
                    break;
                case 10:
                    new Runner10_RegistroAlumnos();
                    break;
                case 11:
                    new JsonTest();
                    break;
                case 12:
                    new JsonArchivoAlumnos();
                    break;
                case 13:
                    new JsonLecturaAlumnos();
                    break;
                case 14:
                    new RunnerExcepcionesPersonalizadas();
                    break;
                case 15 :
                    new RunnerEjecutarOperacionesBasicas();
                    break;
                case 16:
                    new RunnerAreasPoligonos();
                    break;
                case 17:
                    new RunnerAlumnoPuntuacion();
                    break;
                case 18:
                    new RunnerLeerArchivos();
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