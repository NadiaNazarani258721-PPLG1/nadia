using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_1_program_menggunakan_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Tabel Perkalian 5 ---");

            // Perulangan for dimulai dari i=1 hingga i=10
            for (int i = 1; i <= 10; i++)
            {
                // Menghitung hasil perkalian
                int hasil = 5 * i;

                // Menampilkan hasil dalam format: 5 x [i] = [hasil]
                Console.WriteLine($"5 x {i} = {hasil}");
            }

            Console.WriteLine("--------------------");
        }
    }
}
