﻿using System;
namespace Myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter a String :");
            str = Console.ReadLine();
            Console.WriteLine("Converted String is :" + str.ToLower());

        }
    }
}

