﻿using System;
using static System.Console;


namespace SimpleDataTypes_ConsoleApplication
{
    class Program
    {
        static string s = "Hello";  // ohne static ist die Variable nur mit einem Object verfügbar
        static void Main(string[] args)
        {
            string s = "Hello";  // ohne static ist die Variable nur mit einem Object verfügbar
            WriteLine(Program.s);
            ReadLine();
            WriteLine(s);
            ReadLine();
        }
    }
}