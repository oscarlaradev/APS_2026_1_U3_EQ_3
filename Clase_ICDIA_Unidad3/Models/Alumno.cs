namespace Clase_ICDIA_Unidad3.Programas;

/// <summary>
/// Clase que representa un alumno con propiedades de identificación y calificación.
/// Implementa IComparable para permitir comparaciones entre alumnos.
/// </summary>
public class Alumno : IComparable<Alumno>
{
    /// <summary>
    /// Nombre del alumno
    /// </summary>
    private string nombre;
    
    /// <summary>
    /// Matrícula única del alumno (4 dígitos)
    /// </summary>
    private long matricula;
    
    /// <summary>
    /// Calificación del alumno
    /// </summary>
    private double calificacion;
    
    /// <summary>
    /// Propiedad que obtiene o establece la matrícula del alumno.
    /// Valida que sea un número entre 1000 y 9999.
    /// </summary>
    /// <exception cref="ArgumentException">Se lanza si la matrícula no está en el rango válido.</exception>
    public long Matricula
    {
        get => matricula;
        set
        {
            try
            {
                if (value < 1000 || value > 9999)
                {
                    throw new ArgumentException("Matricula debe ser menor a 10000");
                }
                matricula = value;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error en matrícula: {ex.Message}");
                throw;
            }
        }
    }

    /// <summary>
    /// Propiedad que obtiene o establece el nombre del alumno.
    /// Valida que el nombre no exceda 100 caracteres y que no contenga caracteres especiales.
    /// </summary>
    /// <exception cref="NameFormatException">Se lanza si el nombre excede 100 caracteres.</exception>
    /// <exception cref="ArgumentException">Se lanza si el nombre contiene caracteres especiales.</exception>
    public string Nombre 
    { 
        get => nombre;
        set
        {
            try
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "El nombre no puede ser nulo");
                }
                
                if (value.Length > 100)
                {
                    throw new NameFormatException("Nombre debe ser menor a 100 caracteres");
                }

                if (value.Contains("@"))
                {
                    throw new ArgumentException("caracter especial encontrado");
                }
                
                nombre = value;
            }
            catch (NameFormatException ex)
            {
                Console.WriteLine($"Error en formato de nombre: {ex.Message}");
                throw;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error en nombre: {ex.Message}");
                throw;
            }
        } 
    }
    
    /// <summary>
    /// Propiedad que obtiene o establece la calificación del alumno.
    /// </summary>
    public double Calificacion { get => calificacion; set => calificacion = value; }
    
    /// <summary>
    /// Constructor que crea un alumno con nombre y matrícula.
    /// </summary>
    /// <param name="nombre">Nombre del alumno</param>
    /// <param name="matricula">Matrícula del alumno (4 dígitos)</param>
    public Alumno(string nombre, long matricula)
    {
        try
        {
            Matricula = matricula; 
            Nombre = nombre;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al crear alumno: {ex.Message}");
            throw;
        }
    }

    /// <summary>
    /// Constructor que crea un alumno con solo la matrícula.
    /// </summary>
    /// <param name="matricula">Matrícula obligatoria del alumno (4 dígitos)</param>
    public Alumno(long matricula)
    {
        try
        {
            Matricula = matricula;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al crear alumno con matrícula: {ex.Message}");
            throw;
        }
    }

    /// <summary>
    /// Constructor que crea un alumno con nombre, matrícula y calificación.
    /// </summary>
    /// <param name="nombre">Nombre del alumno</param>
    /// <param name="matricula">Matrícula del alumno (4 dígitos)</param>
    /// <param name="calificacion">Calificación inicial del alumno</param>
    public Alumno(string nombre, long matricula, double calificacion)
    {
        try
        {
            Matricula = matricula;
            Nombre = nombre;
            Calificacion = calificacion;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al crear alumno con datos completos: {ex.Message}");
            throw;
        }
    }

    /// <summary>
    /// Constructor vacío que crea un alumno sin parámetros.
    /// </summary>
    public Alumno()
    {
        try
        {
            matricula = 0;
            nombre = "";
            calificacion = 0.0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al crear alumno vacío: {ex.Message}");
            throw;
        }
    }

    /// <summary>
    /// Compara dos alumnos basado en su matrícula.
    /// </summary>
    /// <param name="other">Otro alumno para comparar</param>
    /// <returns>Valor de comparación entre matrículas</returns>
    public int CompareTo(Alumno? other)
    {
        try
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }
            return this.Matricula.CompareTo(other.Matricula);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Error en comparación: {ex.Message}");
            throw;
        }
    }

    /// <summary>
    /// Retorna una representación en cadena del alumno.
    /// </summary>
    /// <returns>Cadena con matrícula y nombre del alumno</returns>
    public override string ToString()
    {
        try
        {
            return "(" + Matricula + ", " + Nombre + ")";
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al convertir a cadena: {ex.Message}");
            return "Error al obtener información del alumno";
        }
    }
}