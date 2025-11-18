using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Praktik_2_nadia_nazaranii_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Memasukan Nilai Siswa ===");

            Console.Write("Nama Siswa :  ");
            string nama = Console.ReadLine();
            Console.Write("Kelas      :  ");
            string kelas = Console.ReadLine();

            Console.Write("Nilai Matematika        :  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nilai Bahasa Indonesia  :  ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nilai Bahasa Inggris    :  ");
            int c = Convert.ToInt32(Console.ReadLine());
            int rata_rata = (a + b + c) / 3;
            Console.WriteLine("Nilai Rata-Rata         :  " + rata_rata);

            Console.WriteLine("=====================================");

            Console.WriteLine("Nama Siswa             : " + nama);
            Console.WriteLine("Kelas                  : " + kelas);
            Console.WriteLine("Nilai Matematika       : " + a);
            Console.WriteLine("Nilai Bahasa Indonesia : " + b);
            Console.WriteLine("Nilai Bahasa Inggris   : " + c);
            Console.WriteLine("Nilai Rata-Rata        : " + rata_rata);
        }
    }
}
