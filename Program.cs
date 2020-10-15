using System;

namespace function
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine ("Please enter the smaller number A = ");
            string userinputA = Console.ReadLine();
            int a = Convert.ToInt32(userinputA);

            Console.WriteLine ("Please enter the larger number B = ");
            string userinputB = Console.ReadLine();
            int b = Convert.ToInt32(userinputB);

            if (a > b)
            {
                Console.WriteLine(" Error !!! A must be smaller then B");
                return;
            }
            // calling function 
            int sum = sumbetweennumbers(a,b);
            Console.WriteLine("= " + sum);
            
        
        }
            //fuction code
            static int sumbetweennumbers(int a, int b)
        {
            int sum = 0;
           
            for (int i = a; i <= b; i++)
            {
                sum += i;
                Console.WriteLine("+" + i);
            }

            Console.WriteLine("---------------------------");
            //Console.WriteLine("=" + sum);
            return sum;

        }
        
    }
}
