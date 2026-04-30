using System;
using System.IO;

namespace Clase_ICDIA_Unidad3.Programas
{
    /// <summary>
    /// Clase que representa una mascota con sus propiedades y características.
    /// </summary>
    public class Mascota
    {
        /// <summary>
        /// Nombre de la mascota
        /// </summary>
        private string nombre;
        
        /// <summary>
        /// Especie de la mascota
        /// </summary>
        private string especie;
        
        /// <summary>
        /// Raza de la mascota
        /// </summary>
        private string raza;
        
        /// <summary>
        /// Edad de la mascota en años
        /// </summary>
        private int edad;
        
        /// <summary>
        /// Peso de la mascota en kilogramos
        /// </summary>
        private double peso;

        /// <summary>
        /// Propiedad para obtener o establecer el nombre de la mascota.
        /// </summary>
        public string Nombre 
        { 
            get => nombre; 
            set 
            { 
                try
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("El nombre no puede estar vacío");
                    nombre = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en nombre de mascota: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer la especie de la mascota.
        /// </summary>
        public string Especie 
        { 
            get => especie; 
            set 
            { 
                try
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("La especie no puede estar vacía");
                    especie = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en especie: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer la raza de la mascota.
        /// </summary>
        public string Raza 
        { 
            get => raza; 
            set 
            { 
                try
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("La raza no puede estar vacía");
                    raza = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en raza: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer la edad de la mascota.
        /// </summary>
        public int Edad 
        { 
            get => edad; 
            set 
            { 
                try
                {
                    if (value < 0)
                        throw new ArgumentException("La edad no puede ser negativa");
                    edad = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en edad: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer el peso de la mascota.
        /// </summary>
        public double Peso 
        { 
            get => peso; 
            set 
            { 
                try
                {
                    if (value < 0)
                        throw new ArgumentException("El peso no puede ser negativo");
                    peso = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en peso: {ex.Message}");
                    throw;
                }
            }
        }

        /// <summary>
        /// Constructor que crea una mascota con todos sus parámetros.
        /// </summary>
        /// <param name="nombre">Nombre de la mascota</param>
        /// <param name="especie">Especie de la mascota</param>
        /// <param name="raza">Raza de la mascota</param>
        /// <param name="edad">Edad de la mascota en años</param>
        /// <param name="peso">Peso de la mascota en kilogramos</param>
        public Mascota(string nombre, string especie, string raza, int edad, double peso)
        {
            try
            {
                Nombre = nombre;
                Especie = especie;
                Raza = raza;
                Edad = edad;
                Peso = peso;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear mascota: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Retorna una representación en cadena de la mascota con todos sus datos.
        /// </summary>
        /// <returns>Cadena formateada con los datos de la mascota</returns>
        public override string ToString()
        {
            try
            {
                return "(" + Nombre + ", " + Especie + ", " + Raza + ", " + Edad + " años, " + Peso + " kg)";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al convertir mascota a cadena: {ex.Message}");
                return "Error al obtener información de la mascota";
            }
        }
    }
}