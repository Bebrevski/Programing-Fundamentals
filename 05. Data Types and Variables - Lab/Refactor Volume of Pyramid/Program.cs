﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght, width, height = 0.0;

            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());

            double volume = (lenght*width*height) / 3;

            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
