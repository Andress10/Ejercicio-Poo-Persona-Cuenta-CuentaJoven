using System;

namespace ConsoleApp1
{
    public class Persona
    {
        private string nombre;
        public int edad;
        private int DNI;

        public Persona(string nombre, int edad, int DNI)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.DNI = DNI;
        }

        /// <summary>
        /// Metodo que devuelve Datos de una persona
        /// </summary>
        public void MostrarDatosDePersona()
        {
            Console.WriteLine($"Nombre: {this.nombre}\t Edad: {this.edad} \t DNI: {this.DNI}");
        }

        /// <summary>
        /// Metodo que devuelve si una persona esz mayor de edad
        /// </summary>
        /// <returns></returns>
        public bool EsMayorDeEdad()
        {

            if (this.edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }


}
