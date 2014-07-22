using System;
using System.Runtime.InteropServices;

namespace call_fortran_from_dotnet_cs
{
    class Program
    {
        [DllImport("funcs.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double __mod_funcs_MOD_mins2secs(ref double minutes);

        [DllImport("funcs.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double __mod_funcs_MOD_secs2mins(ref double seconds);


        static Random rnd = new Random();
        
        static void Main(string[] args)
        {
            //example 1
            //double minutes = 55.5;
            //double seconds = __mod_funcs_MOD_mins2secs(ref minutes);
            //Console.WriteLine(seconds); //prints out 3330

            
            //example 2
            double seconds = 1800.0;
            double minutes = __mod_funcs_MOD_secs2mins(ref seconds);
            Console.WriteLine(minutes); //prints out 300

            
            //loop example
            //double a;
            //for (int i = 0; i < 1000; i++)
            //{
            //    a = rnd.Next();
            //    Console.WriteLine(__mod_funcs_MOD_mins2secs(ref a));
            //}

            Console.ReadLine();
        }
    }
}
