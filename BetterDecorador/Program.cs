using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace BetterDecorador
{
    public class Program
    {
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

       
       
        private static void Main(string[] args)
        {

            Console.WriteLine(Decor(args[0], char.Parse(args[1]), int.Parse(args[2])));
           


            //Console.WriteLine(Decor("Good Morning!", '*', ));
            //Console.WriteLine(Decor("Good Evening!", '.', ));


        }
    }
}
