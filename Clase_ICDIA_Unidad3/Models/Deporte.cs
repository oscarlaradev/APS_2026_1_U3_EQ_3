using System;
using System.IO;

namespace Clase_ICDIA_Unidad3.Programas
{
    /// <summary>
    /// Clase que representa un deporte con sus características principales.
    /// </summary>
    public class Deporte
    {
        /// <summary>
        /// Nombre del deporte
        /// </summary>
        private string nombre;
        
        /// <summary>
        /// Tipo de deporte (e.g., Equipo, Individual)
        /// </summary>
        private string tipo;
        
        /// <summary>
        /// Número de jugadores requeridos
        /// </summary>
        private int numeroJugadores;
        
        /// <summary>
        /// Indica si es un deporte olímpico
        /// </summary>
        private bool esOlimpico;
        
        /// <summary>
        /// Duración promedio del deporte en minutos
        /// </summary>
        private double duracionPromedioMinutos;

        /// <summary>
        /// Propiedad para obtener o establecer el nombre del deporte.
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
                    Console.WriteLine($"Error en nombre de deporte: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer el tipo de deporte.
        /// </summary>
        public string Tipo 
        { 
            get => tipo; 
            set 
            { 
                try
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("El tipo no puede estar vacío");
                    tipo = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en tipo de deporte: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer el número de jugadores.
        /// </summary>
        public int NumeroJugadores 
        { 
            get => numeroJugadores; 
            set 
            { 
                try
                {
                    if (value < 0)
                        throw new ArgumentException("El número de jugadores no puede ser negativo");
                    numeroJugadores = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en número de jugadores: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer si es olímpico.
        /// </summary>
        public bool EsOlimpico 
        { 
            get => esOlimpico; 
            set => esOlimpico = value; 
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer la duración promedio en minutos.
        /// </summary>
        public double DuracionPromedioMinutos 
        { 
            get => duracionPromedioMinutos; 
            set 
            { 
                try
                {
                    if (value < 0)
                        throw new ArgumentException("La duración no puede ser negativa");
                    duracionPromedioMinutos = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en duración: {ex.Message}");
                    throw;
                }
            }
        }

        /// <summary>
        /// Constructor que crea un deporte con todos sus parámetros.
        /// </summary>
        /// <param name="nombre">Nombre del deporte</param>
        /// <param name="tipo">Tipo de deporte</param>
        /// <param name="numeroJugadores">Número de jugadores</param>
        /// <param name="esOlimpico">Indica si es olímpico</param>
        /// <param name="duracionPromedioMinutos">Duración promedio en minutos</param>
        public Deporte(string nombre, string tipo, int numeroJugadores, bool esOlimpico, double duracionPromedioMinutos)
        {
            try
            {
                Nombre = nombre;
                Tipo = tipo;
                NumeroJugadores = numeroJugadores;
                EsOlimpico = esOlimpico;
                DuracionPromedioMinutos = duracionPromedioMinutos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear deporte: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Retorna una representación en cadena del deporte con todos sus datos.
        /// </summary>
        /// <returns>Cadena formateada con los datos del deporte</returns>
        public override string ToString()
        {
            try
            {
                return "(" + Nombre + ", " + Tipo + ", " + NumeroJugadores + " jugadores, Olímpico: " + EsOlimpico + ", " + DuracionPromedioMinutos + " min)";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al convertir deporte a cadena: {ex.Message}");
                return "Error al obtener información del deporte";
            }
        }
    }
}