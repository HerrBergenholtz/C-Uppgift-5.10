﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift_5._10
{
    class Program
    {
        public static void Main()
        {
            int[] nummer = { 2, 5, 1, 8, 1, 8, 3, 8 };
            int mestFörekommandeElement = 0;
            int antal = 0;
            for (int i = 0; i < nummer.Length; i++)
            {
                int förekommer = 0;
                int element = 0;
                for (int j = 0; j < nummer.Length; j++)
                {
                    if (nummer[j] == nummer[i])
                    {
                        förekommer++;
                    }
                    if (förekommer > antal)
                    {
                        mestFörekommandeElement = nummer[i];
                        antal = förekommer;
                    }
                }
            }
            Console.WriteLine(mestFörekommandeElement);
            Console.ReadKey();
        }
    }
}
