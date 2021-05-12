using System;

namespace fizzbuzz
{
    public class Program
    {
        public static string unit(int i){
            int Fizz = i % 3;
            int Buzz = i % 5;
                
            if(Fizz == 0 && Buzz == 0){
                return "FizzBuzz";
            }
            else if(Fizz == 0){
                return "Fizz";
            }
            else if(Buzz == 0){
                return"Buzz";
            }
            else{
               return  i.ToString();
            }
        }

        static void Main(string[] args)
        {
            for(int  i = 1; i < 101; i++)
            {
                Console.WriteLine(unit(i));

            }
        }



    }

}
