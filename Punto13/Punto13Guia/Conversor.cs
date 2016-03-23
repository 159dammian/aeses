using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto13Guia
{
    class Conversor
    {
        public static string DecimalBinario(double Valor) 
        {
            string dato ="";
            string binario = "";
            double resultado;
            //Console.WriteLine("Escriba un numero en decimal para convertir a binario");
            //dato = Console.ReadLine();
           //lor = int.Parse(Console.ReadLine());

            while(true)
            {
                double resto = Valor;
                binario = binario + resto;
                resultado = Valor /2;
                 if(resultado < 3)
                 {
                     break;

                 }


            }

            Console.WriteLine(Valor);
            return dato;


        }

        /*public static double BinarioDecimal(string Valor)
        {
            double dato;
            //Console.WriteLine("Escriba un numero en binario para convertir a decimal");

            

            return dato;
        }*/
    }
}
