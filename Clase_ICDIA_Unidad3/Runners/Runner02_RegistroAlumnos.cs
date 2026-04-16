using Clase_ICDIA_Unidad3.Programas;

namespace Clase_ICDIA_Unidad3.Runners;

public class Runner02_RegistroAlumnos
{
    public Runner02_RegistroAlumnos()
    {
        int opcion = 0;
        int alumnosRegistrados = 0;
        do
        {
            Console.WriteLine("ingresa el numero de la seccion deseada");
            Console.WriteLine("1:registro alumno");
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
                case 0:
                    Console.WriteLine("gracias por usar el programa");
                    break;
            }
        } while (opcion != 0);
    }
}