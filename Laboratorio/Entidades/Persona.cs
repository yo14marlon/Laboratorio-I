using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Entidades
{
    public class Persona
    {

        public void calcularIMC(double peso, double altura)
        {
            double Imc = peso / Math.Pow(altura, 2);
            
            if(Imc >= 25)
            {
                Console.WriteLine("Tienes un IMC de " + Imc + " tienes sobrepeso");
            }
            else 
            {
                Console.WriteLine("Tienes un IMC de " + Imc + " tienes un peso normal");
            }
            
        }

        public void esMayorDeEdad(int Edad, string Nombre, string Sexo)
        {
            Console.WriteLine("n" + Nombre + "\n" + "Sexo:" +Sexo + "\n");
            if(Edad >= 18 ) 
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }
        }

    }
}
