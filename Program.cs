using System;

namespace aulaBrakeys02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Skynet";
            string yo1 = Console.ReadLine();
            string yo2 = Console.ReadLine();


            Console.WriteLine("Hello World!");
            ///Console.ReadKey("enter");
            
            Console.WriteLine("Hello Again");

            Console.WriteLine("Nao aguento mais escrever console write line carai.");
            Console.ReadKey();

            if( yo1 == "poise"){

                Console.WriteLine("Poise?");
                ///Console.ReadKey("Enter");
            }else{
                Console.WriteLine("Poise nao");
                ///Console.ReadKey("space");
            }



        }
    }
}
