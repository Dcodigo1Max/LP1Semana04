using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int v = int.Parse(str);
           

            GetSpecial(v);
            
        }


        private static int GetSpecial(int n)
        {
            GetSpecial(n);

            
            int fact;
            if (n==1)
                fact =1;
            else
                fact = n* Factorial(n-1);
            return fact;
        }
    }
}
