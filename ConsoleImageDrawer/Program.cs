using System;
using System.Drawing;
using System.IO;

namespace ConsoleImageDrawer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Print input bitmap:");
            string sourceFilePath = Console.ReadLine();
            Program.ConsolePrintImage(sourceFilePath);
        }

        private static void ConsolePrintImage(string imagePath)
        {
            Bitmap bitmap;
            try
            {
                bitmap = new Bitmap(imagePath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
                return;
            }

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Program.ConsolePrintPixel(bitmap.GetPixel(i, j));
                }
            }
        }

        private static void ConsolePrintPixel(Color pixel)
        {

        }
    }
}
