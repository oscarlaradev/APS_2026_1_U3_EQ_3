using System;
using System.IO;

namespace Clase_ICDIA_Unidad3.Programas
{
    /// <summary>
    /// Clase que representa un pasatiempo o actividad de ocio con sus características.
    /// </summary>
    public class Pasatiempo
    {
        /// <summary>
        /// Nombre del pasatiempo
        /// </summary>
        private string nombre;
        
        /// <summary>
        /// Descripción del pasatiempo
        /// </summary>
        private string descripcion;
        
        /// <summary>
        /// Horas semanales dedicadas
        /// </summary>
        private int horasSemanales;
        
        /// <summary>
        /// Costo mensual del pasatiempo
        /// </summary>
        private double costoMensual;
        
        /// <summary>
        /// Indica si requiere equipo adicional
        /// </summary>
        private bool requiereEquipo;

        /// <summary>
        /// Propiedad para obtener o establecer el nombre del pasatiempo.
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
                    Console.WriteLine($"Error en nombre de pasatiempo: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer la descripción.
        /// </summary>
        public string Descripcion 
        { 
            get => descripcion; 
            set 
            { 
                try
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("La descripción no puede estar vacía");
                    descripcion = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en descripción: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer las horas semanales.
        /// </summary>
        public int HorasSemanales 
        { 
            get => horasSemanales; 
            set 
            { 
                try
                {
                    if (value < 0)
                        throw new ArgumentException("Las horas no pueden ser negativas");
                    horasSemanales = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en horas semanales: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer el costo mensual.
        /// </summary>
        public double CostoMensual 
        { 
            get => costoMensual; 
            set 
            { 
                try
                {
                    if (value < 0)
                        throw new ArgumentException("El costo no puede ser negativo");
                    costoMensual = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en costo mensual: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer si requiere equipo.
        /// </summary>
        public bool RequiereEquipo 
        { 
            get => requiereEquipo; 
            set => requiereEquipo = value; 
        }

        /// <summary>
        /// Constructor que crea un pasatiempo con todos sus parámetros.
        /// </summary>
        /// <param name="nombre">Nombre del pasatiempo</param>
        /// <param name="descripcion">Descripción del pasatiempo</param>
        /// <param name="horasSemanales">Horas semanales dedicadas</param>
        /// <param name="costoMensual">Costo mensual</param>
        /// <param name="requiereEquipo">Si requiere equipo adicional</param>
        public Pasatiempo(string nombre, string descripcion, int horasSemanales, double costoMensual, bool requiereEquipo)
        {
            try
            {
                Nombre = nombre;
                Descripcion = descripcion;
                HorasSemanales = horasSemanales;
                CostoMensual = costoMensual;
                RequiereEquipo = requiereEquipo;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear pasatiempo: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Retorna una representación en cadena del pasatiempo con todos sus datos.
        /// </summary>
        /// <returns>Cadena formateada con los datos del pasatiempo</returns>
        public override string ToString()
        {
            try
            {
                return "(" + Nombre + ", " + Descripcion + ", " + HorasSemanales + " hrs/sem, $" + CostoMensual + ", Equipo requerido: " + RequiereEquipo + ")";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al convertir pasatiempo a cadena: {ex.Message}");
                return "Error al obtener información del pasatiempo";
            }
        }
    }
}