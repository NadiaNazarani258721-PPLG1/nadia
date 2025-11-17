using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_2_program_menggunakan_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mendeklarasikan variabel
            int N;
            int jumlahTotal = 0;
            int hitungan = 1;

            // Meminta input dari pengguna
            Console.Write("Masukkan bilangan bulat positif (N) untuk dihitung jumlah totalnya dari 1 sampai N: ");

            // Memastikan input adalah bilangan bulat yang valid dan positif
            while (!int.TryParse(Console.ReadLine(), out N) || N < 1)
            {
                Console.WriteLine("Input tidak valid. Harap masukkan bilangan bulat positif (N) yang lebih besar dari atau sama dengan 1:");
            }

            // Menampilkan pesan sebelum memulai perhitungan
            Console.WriteLine($"\nMenghitung jumlah total dari 1 sampai {N} menggunakan perulangan while...");

            // Perulangan while untuk menjumlahkan bilangan
            while (hitungan <= N)
            {
                jumlahTotal += hitungan; // Menambahkan nilai 'hitungan' ke 'jumlahTotal'
                hitungan++;              // Menaikkan nilai 'hitungan' sebanyak 1 (increment)
            }

            // Menampilkan hasil akhir
            Console.WriteLine($"\nJumlah total dari 1 sampai {N} adalah: {jumlahTotal}");
        }
    }
}
