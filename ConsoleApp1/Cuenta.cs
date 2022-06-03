using System;

namespace ConsoleApp1
{
     public class Cuenta
    {

        public Persona titular;
        public double dinero;


        public Cuenta(Persona titular)
        {
            this.titular = titular;
        }
        public Cuenta()
        {

        }
        public Cuenta(double dinero, Persona titular)
        {
            this.dinero = dinero;
            this.titular = titular;
        }

        /// <summary>
        /// Muestra Datos de la persona
        /// </summary>
        public virtual void Mostrar()
        {
            if (this.dinero >= 0)
            {
                this.titular.MostrarDatosDePersona();
                Console.Write("Dinero Persona:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" ${this.dinero} ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                this.titular.MostrarDatosDePersona();
                Console.Write("Dinero Persona:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" ${this.dinero} ");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        /// <summary>
        /// Metodo para ingresar dinero
        /// </summary>
        /// <param name="contadorDinero"></param>
        /// <returns></returns>
        public double Ingresar(double contadorDinero)
        {
            if (contadorDinero > 0)
            {
                this.dinero += contadorDinero;
            }
            return this.dinero;
        }

        /// <summary>
        ///Metodo para retirar dinero 
        /// </summary>
        /// <param name="retirarDinero"></param>
        /// <returns></returns>
        public virtual double Retirar(double retirarDinero)
        {
            if (retirarDinero > 0)
            {
                this.dinero -= retirarDinero;
            }
            return this.dinero;
        }
    }
}
