using System;
using System.IO;

namespace Clase_ICDIA_Unidad3.Programas
{
    /// <summary>
    /// Clase que representa una cancción o pieza musical con sus propiedades.
    /// </summary>
    public class Musica
    {
        /// <summary>
        /// Título de la canción
        /// </summary>
        private string titulo;
        
        /// <summary>
        /// Artista o compositor
        /// </summary>
        private string artista;
        
        /// <summary>
        /// Género musical
        /// </summary>
        private string genero;
        
        /// <summary>
        /// Año de lanzamiento
        /// </summary>
        private int anioLanzamiento;
        
        /// <summary>
        /// Duración de la canción en minutos
        /// </summary>
        private double duracionMinutos;

        /// <summary>
        /// Propiedad para obtener o establecer el título de la canción.
        /// </summary>
        public string Titulo 
        { 
            get => titulo; 
            set 
            { 
                try
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("El título no puede estar vacío");
                    titulo = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en título: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer el artista.
        /// </summary>
        public string Artista 
        { 
            get => artista; 
            set 
            { 
                try
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("El artista no puede estar vacío");
                    artista = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en artista: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer el género musical.
        /// </summary>
        public string Genero 
        { 
            get => genero; 
            set 
            { 
                try
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("El género no puede estar vacío");
                    genero = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en género: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer el año de lanzamiento.
        /// </summary>
        public int AnioLanzamiento 
        { 
            get => anioLanzamiento; 
            set 
            { 
                try
                {
                    if (value < 0 || value > DateTime.Now.Year)
                        throw new ArgumentException("El año de lanzamiento no es válido");
                    anioLanzamiento = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en año de lanzamiento: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer la duración en minutos.
        /// </summary>
        public double DuracionMinutos 
        { 
            get => duracionMinutos; 
            set 
            { 
                try
                {
                    if (value < 0)
                        throw new ArgumentException("La duración no puede ser negativa");
                    duracionMinutos = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en duración: {ex.Message}");
                    throw;
                }
            }
        }

        /// <summary>
        /// Constructor que crea una canción con todos sus parámetros.
        /// </summary>
        /// <param name="titulo">Título de la canción</param>
        /// <param name="artista">Artista o compositor</param>
        /// <param name="genero">Género musical</param>
        /// <param name="anioLanzamiento">Año de lanzamiento</param>
        /// <param name="duracionMinutos">Duración en minutos</param>
        public Musica(string titulo, string artista, string genero, int anioLanzamiento, double duracionMinutos)
        {
            try
            {
                Titulo = titulo;
                Artista = artista;
                Genero = genero;
                AnioLanzamiento = anioLanzamiento;
                DuracionMinutos = duracionMinutos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear música: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Retorna una representación en cadena de la canción con todos sus datos.
        /// </summary>
        /// <returns>Cadena formateada con los datos de la canción</returns>
        public override string ToString()
        {
            try
            {
                return "(" + Titulo + ", " + Artista + ", " + Genero + ", " + AnioLanzamiento + ", " + DuracionMinutos + " min)";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al convertir música a cadena: {ex.Message}");
                return "Error al obtener información de la música";
            }
        }
    }
}