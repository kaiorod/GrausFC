using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            double f, convc;

            Console.Clear();
            Console.Beep();
            Console.Write("Digite a temperatura em ºF : ");
            f = double.Parse(Console.ReadLine());

            convc = (f - 32) / 1.8;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{convc} ºC"); 
            Console.ResetColor();          
        }
    }
}
