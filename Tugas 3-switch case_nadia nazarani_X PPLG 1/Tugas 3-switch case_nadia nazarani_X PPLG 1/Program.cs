using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_3_switch_case_nadia_nazarani_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan angka (1-5) = ");
            int warna = int.Parse(Console.ReadLine());

            switch (warna)
            {
                case 1: Console.WriteLine("merah");  break; 
                case 2: Console.WriteLine("biru");   break;
                case 3: Console.WriteLine("hijau");  break;
                case 4: Console.WriteLine("kuning"); break;
                case 5: Console.WriteLine("hitam");  break;
                default: Console.WriteLine("Input warna tidak valid!"); break;
            }
        }
    }
}
