using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for( i = 1; i < 101; i++)
            {
                int Fizz = i % 3;
                int Buzz = i % 5;
                	if(Fizz == 0){
                        Console.WriteLine("Fizz");
                    }
                	else if(Buzz == 0){
                        Console.WriteLine("Buzz");
                    }
                    else{
                        Console.WriteLine(i);
                    }
            }
        }
    }
}
