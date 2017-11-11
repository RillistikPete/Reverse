using System;
using System.Text;

namespace InterviewQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str = "Short string";
            //char[] cArray = Str.ToCharArray();
            StringBuilder sb = new StringBuilder();

            // var length = cArray.Length;
            for (int i = Str.Length - 1; i >= 0; i--)
            {
                sb.Append(Str[i]);
            }
            Console.WriteLine(sb);  

        }
    }
}