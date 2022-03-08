using System;
namespace alistirma_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Odanizin sicakligi giriniz: ");
            double sicaklik = double.Parse(Console.ReadLine());
            double fahrenheit = (9/5f*sicaklik) +32;
            Console.WriteLine("Odanizin Fahrenheit sicakligi {0}" ,fahrenheit);
        }
    }
}