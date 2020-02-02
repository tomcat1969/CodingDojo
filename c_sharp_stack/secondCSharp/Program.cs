using System;

namespace secondCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string aa = "huang";
            Console.WriteLine($"Hello World!{aa}");
            Console.WriteLine("The value of pi is " + 3.14159);

            for (int i =1; i <= 255; i++) {
                Console.Write("{0} ",i);
            }
            Console.WriteLine("*************");
            for (int i = 1; i <= 100; i++){
                if(i % 3 == 0 && i % 5 == 0){
                    continue;
                }else if (i % 3 == 0 || i % 5 == 0) {
                    Console.Write("{0} ",i);
                }
            }
            Console.WriteLine("*****Fizz & buzz********");
            for (int i = 1; i <= 100; i++){
                if(i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine("{0} --- FizzBuzz",i);
                }else if (i % 3 == 0) {
                    Console.WriteLine("{0} ---Fizz ",i);
                }else if (i % 5 == 0) {
                    Console.WriteLine("{0} --- Buzz",i);
                }
            }




        }
    }
}
