using System;
using System.Drawing;
using System.IO;

namespace ConsoleImageDrawer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            Console.WriteLine("Print input bitmap:");
            string sourceFilePath = Console.ReadLine();
            */
            string sourceFilePath = "st.bmp";
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
            catch (Exception)
            {
                Console.WriteLine("Internal error");
                return;
            }

            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Program.ConsolePrintPixel(bitmap.GetPixel(j, i));
                }

                Console.WriteLine();
            }
        }

        private static void ConsolePrintPixel(Color pixel)
        {
            int index = (pixel.R > 128 | pixel.G > 128 | pixel.B > 128) ? 8 : 0;
            index |= (pixel.R > 64) ? 4 : 0;
            index |= (pixel.G > 64) ? 2 : 0;
            index |= (pixel.B > 64) ? 1 : 0;
            Console.ForegroundColor = (ConsoleColor)index;
            Console.Write("██");
        }
    }
}
