using Clase_ICDIA_Unidad3.Programas;

namespace Clase_ICDIA_Unidad3.Runners;

public class Runner01_Archivoalumno
{
    public Runner01_Archivoalumno()
    {
        Alumno al1 = new Alumno("juan perez",1);
        Alumno al2 = new Alumno("juan sanchez",2);
        Alumno al3 = new Alumno("juan segundo",3 );
        
        StreamWriter sw = new StreamWriter("alumnos.csv",true);
        sw.WriteLine(al1.Matricula + "," + al2.Nombre);
        sw.WriteLine(al2.Matricula + "," + al2.Nombre);
        sw.WriteLine(al3.Matricula + "," + al3.Nombre);
        
        sw.Flush();
        sw.Close();
        
    }
}