﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxSugarExercise
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            var answer = 4;
            var response = (answer < 9)? $"{answer} is less than nine" : $"{answer} is greater than or equals to nine";
            Console.WriteLine(response);
        }
    }
}
