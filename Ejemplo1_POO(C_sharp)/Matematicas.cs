using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_POO_C_sharp_
{
    //Primero defino el acceso a la clase(public).
     public class Matematicas
    {
        //Se definen los atributos o variables de la clase.
        //Por recomendacion se crea de manera privada.
        private double numero1;
        private double numero2;
        //Se crean los metodos de tipo setter y getter.
        public void setNumero1(double valor) {

            this.numero1 = valor;
        }

        public double getNumero1() {

            return this.numero1;
        }

        public void setNumero2(double valor) {

            this.numero2 = valor;
        }

        public double getNumero2() {

            return this.numero2;
        }

        public double sumar() {

            return (this.getNumero1() + this.getNumero2());  
        }

        public double resta() {


            return (this.getNumero1() - this.getNumero2());
        }

        public double multiplicacion() {

            return (this.getNumero1() * this.getNumero2());
        }

        public double division() {

            return (this.getNumero1() / this.getNumero2());
        }


    }
}
