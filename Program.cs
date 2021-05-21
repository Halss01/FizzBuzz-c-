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
            Console.WriteLine("Zadej číslo od 1 od 100 nebo all aby se spustil program.");
            String input = Console.ReadLine();
            int number;
            if(input == "all"){
                for(int  i = 1; i < 101; i++)
                {
                    Console.WriteLine(unit(i));
                }
            }
            else if(int.TryParse(input, out number) && number > 1 && number < 100){
                Console.WriteLine(unit(number));
            }
            else{
                Console.WriteLine("Špatně zadaná hodnota.");
            }
        }
    }

}
