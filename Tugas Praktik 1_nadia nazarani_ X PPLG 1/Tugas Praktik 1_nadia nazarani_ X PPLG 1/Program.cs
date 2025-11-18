using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Praktik_1_nadia_nazarani__X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Operator Matematika ===");

            Console.Write("Masukan angka pertama:   ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan angka kedua:     ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan angka ketiga:    ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("===================================");

            Console.WriteLine("Hasil penjumlahan: " + (a + b + c));
            Console.WriteLine("Hasil pengurangan: " + (a - b - c));
            Console.WriteLine("Hasil perkalian:   " + (a * b * c));
            Console.WriteLine("Hasil pembagian:   " + (a / b / c));
        }
    }
}
