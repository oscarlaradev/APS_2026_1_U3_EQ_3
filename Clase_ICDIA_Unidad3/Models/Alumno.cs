namespace Clase_ICDIA_Unidad3.Programas;

public class Alumno
{
    //atributos
    private string nombre;
    private long matricula;
    
    //propiedades
    public long Matricula { get => matricula; set => matricula = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    
    //constructor

    public Alumno(string nombre, long matricula)
    {
        Matricula = matricula; 
        Nombre = nombre;
    }
    
    //toString

    public override string ToString()
    {
        return "(" + Matricula + ", " + Nombre + ")";
    }
}