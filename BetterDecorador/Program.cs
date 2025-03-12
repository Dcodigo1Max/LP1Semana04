using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace BetterDecorador
{

    /// <summary>
    /// O programa recebe um string, 
    /// nesse string são adicionados caracteres,
    /// pelo Metodo Decor, que indica atraves do ciclo nele,
    /// o numero atraves dos dados escritos 
    // na consola pelo utilizador.
    /// </summary>
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
        ///  e faz a conversão das variaveis necessarias para string;
        ///  Tem tambem agora um if e else para especificar que:
        ///  se o utilizador não por os inputs na consola é chamado o 
        ///  Decor vazio;
        ///  Ou então ele escreve normalmente
        /// </summary>
        /// <param name="args"></param>

        private static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine(Decor());
            }
            else
            {
                Console.WriteLine(Decor(args[0], char.Parse(args[1]), int.Parse(args[2])));
            }
            
           


            //Console.WriteLine(Decor("Good Morning!", '*', ));
            //Console.WriteLine(Decor("Good Evening!", '.', ));


        }
    
        /// <summary>
        /// Este metodo faz com que no caso 
        /// de não haver input na consola
        /// o programa escreva o codigo em baixo
        /// </summary>
        /// <returns></returns>
            
            private static string Decor()
            {
            string s_part = "User did not specify args!"; 
            char dec_part = '=';
            int numbers_part = 3;
            
            string input_solution = Decor(s_part, dec_part, numbers_part);
            
            return input_solution;
            
        }
           
        
    
    
    }


}
