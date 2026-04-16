namespace Clase_ICDIA_Unidad3.Runners
{
    using Clase_ICDIA_Unidad3.Programas;

    public class Runner05_RegistroMusica
    {
        public Runner05_RegistroMusica()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("ingresa el numero de la seccion deseada");
                Console.WriteLine("1: registro cancion");
                Console.WriteLine("0: salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingresa el titulo de la cancion");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("ingresa el artista");
                        string artista = Console.ReadLine();
                        Console.WriteLine("ingresa el genero musical");
                        string genero = Console.ReadLine();
                        Console.WriteLine("ingresa el año de lanzamiento");
                        int anio = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingresa la duracion en minutos (ej. 3.5)");
                        double duracion = Convert.ToDouble(Console.ReadLine());

                        Musica cancion = new Musica(titulo, artista, genero, anio, duracion);

                        //guardar musica
                        StreamWriter sw = new StreamWriter("registro_musica.csv", true);
                        sw.WriteLine(cancion.Titulo + "," + cancion.Artista + "," + cancion.Genero + "," + cancion.AnioLanzamiento + "," + cancion.DuracionMinutos);
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
}