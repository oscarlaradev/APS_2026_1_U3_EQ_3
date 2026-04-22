namespace Clase_ICDIA_Unidad3.Programas;

public class MatriculaException : Exception
{
    public MatriculaException(string message) : base(message)
    {
        //guardar en la base de datos que ocurrio este error
        
    }
}