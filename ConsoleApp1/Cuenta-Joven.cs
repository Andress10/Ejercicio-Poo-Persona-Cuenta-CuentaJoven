using System;

namespace ConsoleApp1
{
    public class Cuenta_Joven : Cuenta
    {

        private double bonificacion;
        private double dineroJoven;

        public Cuenta_Joven(double dinero, Persona titular)
        {
            this.titular = titular;
            this.dineroJoven = dinero;
        }
        public Cuenta_Joven( Persona titular)
        {
            this.titular = titular;
        }

     
        /// <summary>
        /// Metodo que devuelve
        /// </summary>
        /// <param name="retirarDinero"></param>
        /// <returns></returns>
        public override double Retirar(double retirarDinero)
        {
            double bonus= this.bonificacion = 0.10;
            if (base.titular.edad >= 18 && base.titular.edad < 25)
            {
                base.dinero = (base.dinero - this.dineroJoven + (retirarDinero*bonus)) - retirarDinero;
                return this.dineroJoven ;
            }          
            else
            {
                return this.dineroJoven;
            }

        }
       
        public bool EsTitularValido()
        {
            if (base.titular.edad >= 18 && base.titular.edad < 25)
            {              
                return true;
            }
            else if (base.titular.edad < 18 && base.titular.edad > 25)
            {               
                return false;
            }
            else
            {
                return false;
            }
        }

    }
}
