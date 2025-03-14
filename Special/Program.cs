using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insert n-th number of the special sequence");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine($"{GetSpecial(v)}");

            
            
        }


        private static int GetSpecial(int n)
        {            
            int ponto;
            if (n==0)
                ponto =0;
            else if(n==1)
            {
                ponto =1;
            }
            else
                ponto =GetSpecial(n-1) +(2 * GetSpecial(n-2));
            return ponto;
        }
    }
}
