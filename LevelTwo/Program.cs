using System;
using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string image_file;
            int size_width;
            
            if (args.Length < 2)
            {
                image_file = "tux.jpg";
                size_width = 24;
            }
            else
            {
                image_file = args[0];
                size_width = int.Parse(args[1]);
            }
            CanvasImage image = new CanvasImage(image_file);
            image.MaxWidth(size_width);
            AnsiConsole.Write(image);
        }
    }
}
