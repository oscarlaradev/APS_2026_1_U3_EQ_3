namespace Clase_ICDIA_Unidad3.Runners
{
    using Clase_ICDIA_Unidad3.Programas;

    public class Runner04_RegistroMascotas
    {
        public Runner04_RegistroMascotas()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("ingresa el numero de la seccion deseada");
                Console.WriteLine("1: registro mascota");
                Console.WriteLine("0: salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingresa el nombre de la mascota");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("ingresa la especie (ej. Perro, Gato)");
                        string especie = Console.ReadLine();
                        Console.WriteLine("ingresa la raza");
                        string raza = Console.ReadLine();
                        Console.WriteLine("ingresa la edad");
                        int edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingresa el peso en kg");
                        double peso = Convert.ToDouble(Console.ReadLine());

                        Mascota mascota = new Mascota(nombre, especie, raza, edad, peso);

                        //guardar mascota
                        StreamWriter sw = new StreamWriter("registro_mascotas.csv", true);
                        sw.WriteLine(mascota.Nombre + "," + mascota.Especie + "," + mascota.Raza + "," + mascota.Edad + "," + mascota.Peso);
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