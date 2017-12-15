using System;
using System.Linq;
using System.Text;

namespace InterviewQ2
{
    class Program
    {
        public static string Alternative (string AltStr)
        {
            char [] reversed = new char[AltStr.Length];
            int moveup = 0;
            for (var j=(AltStr.Length - 1); j>=0; j--)
            {
                reversed[moveup++] = AltStr[j];
            }
           return new string(reversed);
        }
        static void Main(String[] args)
        {
            string Str = "Short string";
            
            StringBuilder sb = new StringBuilder();
            for (int i = (Str.Length - 1); i >= 0; i--)
            {
                sb.Append(Str[i]);
            }
            Console.WriteLine("{0}", sb);  
            Console.WriteLine(Alternative("Alternative to StringBuilder with CharArray"));
        }
        
    }
}