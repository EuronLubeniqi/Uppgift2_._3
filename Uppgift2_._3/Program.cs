using System;
namespace Uppgift2_._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar ska du använda bilen");
            int dagar = int.Parse(Console.ReadLine());
            int Dag1 = 300;
            int Övrigadagar = 500;
            Console.WriteLine("Hur många kilometer ska du köra bilen?");
            int kilometer = int.Parse(Console.ReadLine());  
            int sum = Dag1 + Övrigadagar + kilometer;
            Console.WriteLine(sum);





        }










    }










}
