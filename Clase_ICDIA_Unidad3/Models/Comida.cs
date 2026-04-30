using System;
using System.IO;

namespace Clase_ICDIA_Unidad3.Programas
{
    /// <summary>
    /// Clase que representa una comida con sus propiedades nutricionales y características.
    /// </summary>
    public class Comida
    {
        /// <summary>
        /// Nombre de la comida
        /// </summary>
        private string nombre;
        
        /// <summary>
        /// Categoría de la comida
        /// </summary>
        private string categoria;
        
        /// <summary>
        /// Precio de la comida
        /// </summary>
        private double precio;
        
        /// <summary>
        /// Calorías de la comida
        /// </summary>
        private int calorias;
        
        /// <summary>
        /// Indica si la comida es picante
        /// </summary>
        private bool esPicante;

        /// <summary>
        /// Propiedad para obtener o establecer el nombre de la comida.
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
                    Console.WriteLine($"Error en nombre de comida: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer la categoría de la comida.
        /// </summary>
        public string Categoria 
        { 
            get => categoria; 
            set 
            { 
                try
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("La categoría no puede estar vacía");
                    categoria = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en categoría: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer el precio de la comida.
        /// </summary>
        public double Precio 
        { 
            get => precio; 
            set 
            { 
                try
                {
                    if (value < 0)
                        throw new ArgumentException("El precio no puede ser negativo");
                    precio = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en precio: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer las calorías de la comida.
        /// </summary>
        public int Calorias 
        { 
            get => calorias; 
            set 
            { 
                try
                {
                    if (value < 0)
                        throw new ArgumentException("Las calorías no pueden ser negativas");
                    calorias = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error en calorías: {ex.Message}");
                    throw;
                }
            }
        }
        
        /// <summary>
        /// Propiedad para obtener o establecer si la comida es picante.
        /// </summary>
        public bool EsPicante 
        { 
            get => esPicante; 
            set => esPicante = value; 
        }

        /// <summary>
        /// Constructor que crea una comida con todos sus parámetros.
        /// </summary>
        /// <param name="nombre">Nombre de la comida</param>
        /// <param name="categoria">Categoría de la comida</param>
        /// <param name="precio">Precio de la comida</param>
        /// <param name="calorias">Calorías de la comida</param>
        /// <param name="esPicante">Indica si es picante</param>
        public Comida(string nombre, string categoria, double precio, int calorias, bool esPicante)
        {
            try
            {
                Nombre = nombre;
                Categoria = categoria;
                Precio = precio;
                Calorias = calorias;
                EsPicante = esPicante;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear comida: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Retorna una representación en cadena de la comida con todos sus datos.
        /// </summary>
        /// <returns>Cadena formateada con los datos de la comida</returns>
        public override string ToString()
        {
            try
            {
                return "(" + Nombre + ", " + Categoria + ", $" + Precio + ", " + Calorias + " kcal, Picante: " + EsPicante + ")";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al convertir comida a cadena: {ex.Message}");
                return "Error al obtener información de la comida";
            }
        }
    }
}