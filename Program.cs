﻿using System;
using System.Text;

namespace InterviewQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str = "Short string";
            //Decided not to use .ToCharArray()
            StringBuilder sb = new StringBuilder();
            for (int i = Str.Length - 1; i >= 0; i--)
            {
                sb.Append(Str[i]);
            }
            Console.WriteLine(sb);  
        }
    }
}