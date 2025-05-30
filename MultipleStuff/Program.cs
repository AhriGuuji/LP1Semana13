
﻿using System;

namespace MultipleStuff
{
    public class Program
    {
        private static void Main(string[] args)
        {
            SuperList numeros = new SuperList { 15.7, 3.2, 42.8, 8.1, 27.5, 1.9, 99.3, 12.0, 5.4, 73.6 };
            
            numeros.GetMinMax1(out double min1, out double max1);
            Console.WriteLine($"V.1 - Min: {min1}, Max: {max1}");
            
            SuperList.MinMaxResult resultado2 = numeros.GetMinMax2();
            Console.WriteLine($"V.2 - {resultado2}");
            
            var (minimo, maximo) = numeros.GetMinMax3();
            Console.WriteLine($"V.3 - Min: {minimo}, Max: {maximo}");

            var (min4, max4) = numeros.GetMinMax4();
            Console.WriteLine($"V.4 - Min: {min4}, Max: {max4}");
        }
    }
}
