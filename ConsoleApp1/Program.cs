using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Tomas", 50, 40917504);
            Persona persona2 = new Persona("Manuel", 20, 40917504);

            persona1.MostrarDatosDePersona();
            persona2.MostrarDatosDePersona();

            Console.WriteLine($"Esta persona es mayor de Edad?: {persona1.EsMayorDeEdad()}");
            Console.WriteLine($"Esta persona es mayor de Edad?: {persona2.EsMayorDeEdad()}");


            Console.WriteLine();


       
            Console.WriteLine("\n \n \n");
            Cuenta cuentaTitular = new Cuenta(30000.50, persona1);
            Cuenta cuentaTitular2 = new Cuenta( persona2);

            cuentaTitular.Ingresar(40000);
            cuentaTitular.Mostrar();
            cuentaTitular.Retirar(72000);
            cuentaTitular.Mostrar();
            Console.WriteLine();

            cuentaTitular2.Ingresar(100000);
            cuentaTitular2.Mostrar();

            Console.WriteLine("\n \n ");
         

       

            #region Muetra cuenta joven True
            Cuenta_Joven cuentaJoven1 = new Cuenta_Joven(persona2);
            Console.WriteLine(cuentaJoven1.EsTitularValido());
            cuentaJoven1.Ingresar(8000);
            cuentaJoven1.Mostrar();
            cuentaJoven1.Retirar(1000);
            cuentaJoven1.Mostrar();
            cuentaJoven1.Retirar(1000);
            cuentaJoven1.Mostrar();
            #endregion

            Console.WriteLine("\n \n ");

            #region Muetra cuenta joven False
            Cuenta_Joven cuentaJoven2 = new Cuenta_Joven(persona1);
            Console.WriteLine(cuentaJoven2.EsTitularValido());
            cuentaJoven2.Ingresar(8000);
            cuentaJoven2.Mostrar();
            cuentaJoven2.Retirar(1000);
            cuentaJoven2.Mostrar();
            cuentaJoven2.Retirar(1000);
            cuentaJoven2.Mostrar();
            #endregion
        }
    }
}
