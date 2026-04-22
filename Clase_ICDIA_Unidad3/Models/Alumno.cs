namespace Clase_ICDIA_Unidad3.Programas;

public class Alumno : IComparable<Alumno>
{
    //atributos
    private string nombre;
    private long matricula;
    private double calificacion;
    
    //propiedades
    public long Matricula
    {
        get => matricula;
        set
        {
            if (matricula <1000 || matricula > 9999)
            {
                throw new ArgumentException("Matricula debe ser menor a 10000");
            }
        }
    }

    public string Nombre 
    { get => nombre;
        set
        {
            if (value.Length > 100)
            {
                throw new NameFormatException ("Nombre debe ser menor a 100 caracteres");
            }

            if (value.Contains("@"))
            {
                throw  new ArgumentException("caracter especial encontrado ");
            }
        } 
    }
    public double Calificacion { get => calificacion; set => calificacion = value; }
    
    //constructor

    public Alumno(string nombre, long matricula)
    {
        Matricula = matricula; 
        Nombre = nombre;
    }

    public Alumno(long matricula)
    { //matricula obligatorio 4 digitos
        Matricula = matricula;
    }

    public Alumno(string nombre, long matricula, double calificacion)
    {
        Matricula = matricula;
        Nombre = nombre;
        Calificacion = calificacion;
    }

    public Alumno()
    {
        
    }

    public int CompareTo(Alumno? other)
    {
        return
        this.Matricula.CompareTo(other.Matricula);
    }

    //toString

    public override string ToString()
    {
        return "(" + Matricula + ", " + Nombre + ")";
    }
}