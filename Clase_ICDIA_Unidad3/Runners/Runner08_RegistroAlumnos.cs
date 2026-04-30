using Clase_ICDIA_Unidad3.Programas;

namespace Clase_ICDIA_Unidad3.Runners;

/// <summary>
/// Runner para registro y visualizacion de alumnos con carga de archivo.  
/// </summary>
public class Runner08_RegistroAlumnos
{
    /// <summary>
    /// Constructor que carga alumnos del archivo y permite registrar nuevos.
    /// </summary>
    public Runner08_RegistroAlumnos()
    {
        try
        {

        string ruta = "registro.csv";
        List<Alumno> alumnos = new List<Alumno>();
        if (File.Exists(ruta)) //si existe el archivo
        {
            //cargamos el archivo
            foreach (string linea in File.ReadLines(ruta))
            {
                string[] datos = linea.Split(',');
                long matricula = Convert.ToInt64(datos[0]);
                string nombre = datos[1];
                Alumno al = new Alumno(nombre, matricula);
                alumnos.Add(al);
            }
        }
        else
        {
            Console.WriteLine("no exite registro previo"); 
        }

        foreach (Alumno alumno in alumnos)
        {
            Console.WriteLine(alumno);
        }
        
        int alumnosRegistrados = alumnos.Count;
        int opcion = 0;
        do
        {
            Console.WriteLine("ingresa el numero de la seccion deseada");
            Console.WriteLine("1:registro alumno");
            Console.WriteLine("2:visualizar alumno");
            Console.WriteLine("0: salir");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("ingresa el nombre del alumno");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingresa la matricula del alumno");
                    long matricula = Convert.ToInt64(Console.ReadLine());
                    Alumno alumno = new Alumno(nombre, matricula);
                    
                    //guardar alumno
                    StreamWriter sw = new StreamWriter("registro.csv", true);
                    sw.WriteLine(alumno.Matricula + "," + alumno.Nombre);
                    sw.Flush();
                    sw.Close();
                    break;
                case 2:
                    Console.WriteLine("Lista de alumnos registrados:\n");

                    if (alumnos.Count == 0)
                    {
                        Console.WriteLine("No hay alumnos registrados.");
                    }
                    else
                    {
                        foreach (Alumno al in alumnos)
                        {
                            Console.WriteLine(al);
                        }
                    }
                    break;
                case 0:
                    Console.WriteLine("gracias por usar el programa");
                    break;
            }
        } while (opcion != 0);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en Runner08: {ex.Message}");
        }
    }
}