using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {

            float coxinha = 5.75f;
            float acrescimo_catupiry = 1.00f;
            float coxinhaCatupiry = coxinha + acrescimo_catupiry;


            Console.WriteLine(" a coxinha custa R$ " + coxinha);
            Console.WriteLine(" acréscimo de catupiry: R$ " + acrescimo_catupiry);
            Console.WriteLine(" a coxinha com catupiry R$ "+ coxinhaCatupiry);

            // a calculadora de IMC 
            float peso = 70.0f;
            float altura = 1.57f;
            float IMC = peso / (altura * altura);

            Console.WriteLine("\n seu IMC é de: "+ IMC);


            Console.ReadKey();
            



        }
    }
}
