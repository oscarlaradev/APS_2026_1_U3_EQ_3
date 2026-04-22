using System.Text.Json;
using Clase_ICDIA_Unidad3.Programas;

namespace Clase_ICDIA_Unidad3.Runners;

public class JsonArchivoAlumnos
{
    public JsonArchivoAlumnos()
    {
        Alumno al1;
        Alumno al2;
        Alumno al3;

        Random random;
        StreamWriter sw;
        StreamReader sr;
        
        
        //de clases estaticas no se pueden generar objetos 
        //JsonSerializer serializer
        //Math math
        
        al1 = new Alumno("oscar",1,10);
        al2 = new Alumno("luna",2,10);
        al3 = new Alumno("fernando",3,9);
        
        sw = new StreamWriter("alumnos.json");
        
        string json = JsonSerializer.Serialize(al1);
        sw.WriteLine(json);
        
        json = JsonSerializer.Serialize(al2);
        sw.WriteLine(json);
        
        json = JsonSerializer.Serialize(al3);
        sw.WriteLine(json);
        
        sw.Flush();
        sw.Close();
    }
}