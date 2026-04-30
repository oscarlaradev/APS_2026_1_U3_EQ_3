using Clase_ICDIA_Unidad3.Programas;

namespace Clase_ICDIA_Unidad3.Runners;

/// <summary>
/// Runner para registro, visualizacion, eliminacion y guardado de alumnos.
/// Permite guardar los cambios realizados en el archivo.
/// </summary>
public class Runner10_RegistroAlumnos
{
    /// <summary>
    /// Constructor que ejecuta operaciones completas de gestion de alumnos.
    /// </summary>
    public Runner10_RegistroAlumnos()
    {
        try
        {
        long matricula;
        string nombre;

        string ruta = "registro.csv";
        List<Alumno> alumnos = new List<Alumno>();
        if (File.Exists(ruta)) //si existe el archivo
        {
            //cargamos el archivo
            foreach (string linea in File.ReadLines(ruta))
            {
                string[] datos = linea.Split(',');
                matricula = Convert.ToInt64(datos[0]);
                nombre = datos[1];
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
            Console.WriteLine("3: Eliminar registros");
            Console.WriteLine("4: Guardar Cambios");
            Console.WriteLine("0: salir");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("ingresa el nombre del alumno");
                    nombre = Console.ReadLine();
                    Console.WriteLine("ingresa la matricula del alumno");
                    matricula = Convert.ToInt64(Console.ReadLine());
                    Alumno alumno = new Alumno(nombre, matricula);
                    alumnos.Add(alumno);
                   
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
                case 3:
                    Console.WriteLine("ingresa la matricula a eliminar");
                    matricula = Convert.ToInt64(Console.ReadLine());
                    Alumno temporal = new Alumno(matricula);
                    bool resultados = alumnos.Contains(new Alumno(matricula));
                    Console.WriteLine(resultados);
                    if (resultados)
                    {
                        alumnos.Remove(temporal);
                    }
                    break;
                case 4://guardar cambios
                    StreamWriter sw = new StreamWriter("registro.csv");
                    foreach (Alumno alu in alumnos)
                    {
                        sw.WriteLine(alu.Matricula + "," + alu.Nombre);
                        //alumnos.Remove(alu);
                    }
                    sw.Flush();
                    sw.Close();
                    Console.WriteLine("cambios guardados correctamente");
                    break;
                case 0:
                    Console.WriteLine("gracias por usar el programa");
                    break;
            }
        } while (opcion != 0);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en Runner10: {ex.Message}");
        }
    }
}