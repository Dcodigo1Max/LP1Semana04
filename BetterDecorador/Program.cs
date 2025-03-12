using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// Este codigo vai fazer um ciclo utilizando os caracteres atribuidos mais 
        /// outros valores para poder contar o numero de vezes que o caracter aparece
        /// de acordo com o input que o utilizador escreve na consola
        /// </summary>
        /// <param name="s">variavel tipo string da frase que vai ser imprimida</param>
        /// <param name="dec">Caracteres que aparecem no inicio e no fim da string</param>
        /// <param name="numbers">variavel que tem o numero de vezes que um caracter é inserido</param>
        /// <returns></returns>
        private static string Decor(string s, char dec, int numbers)
            {

                int n = 0;
                s= " " + s + " ";

                while(n !=numbers)
                {
                    s = dec + s + dec;
                    ++n;
                }
                return s;
                
                
                //return $"{Convert.ToString(dec)}{Convert.ToString(dec)}{Convert.ToString(dec)}{s} {Convert.ToString(dec)}{Convert.ToString(dec)}{Convert.ToString(dec)}{Convert.ToString(numbers)}"; 
                
                 
            
            }

        /// <summary>
        /// Imprime o Metodo Decor de acordo com os parametros fornecidos
        ///  e faz a conversão das variaveis necessarias para string
        /// </summary>
        /// <param name="args"></param>

        private static void Main(string[] args)
        {

            Console.WriteLine(Decor(args[0], char.Parse(args[1]), int.Parse(args[2])));
           


            //Console.WriteLine(Decor("Good Morning!", '*', ));
            //Console.WriteLine(Decor("Good Evening!", '.', ));


        }
    }
}
