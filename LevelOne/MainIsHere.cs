using System;

namespace LevelOne
{
    /// <summary>
    /// program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args">no args</param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP!");
            PrintSomething("olá mundo!");
        }
        /// <summary>
        ///  print something
        /// </summary>
        /// <param name="phrase"></param>
        private static void PrintSomething(string phrase)
        {
            Console.WriteLine(phrase);
        }
    }
}
