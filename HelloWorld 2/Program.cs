using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nama;
            Console.WriteLine("Masukan nama : ");
            nama = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hallo " + nama + " Selamat datang di C#!");
        }
    }
}
