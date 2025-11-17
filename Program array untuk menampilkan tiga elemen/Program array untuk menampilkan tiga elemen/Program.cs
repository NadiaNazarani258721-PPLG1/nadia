using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_array_untuk_menampilkan_tiga_elemen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nama = new string[3];
            char[] jk = new char[3];
            string[] kelas = new string[3];

            Console.Write("Masukkan nama siswa ke-1: "); nama[0] = Console.ReadLine() ?? string.Empty;
            Console.Write("Masukkan jenis kelamin (L/P): "); jk[0] = char.Parse(Console.ReadLine() ?? "0");
            Console.Write("Masukkan kelas: "); kelas[0] = Console.ReadLine() ?? string.Empty;

            Console.Write("Masukkan nama siswa ke-2: "); nama[1] = Console.ReadLine() ?? string.Empty;
            Console.Write("Masukkan jenis kelamin (L/P): "); jk[1] = char.Parse(Console.ReadLine() ?? "0");
            Console.Write("Masukkan kelas: "); kelas[1] = Console.ReadLine() ?? string.Empty;

            Console.Write("Masukkan nama siswa ke-3: "); nama[2] = Console.ReadLine() ?? string.Empty;
            Console.Write("Masukkan jenis kelamin (L/P): "); jk[2] = char.Parse(Console.ReadLine() ?? "0");
            Console.Write("Masukkan kelas: "); kelas[2] = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("\n=== Data Siswa ===");
            Console.WriteLine($"Nama: {nama[0]} | Jenis Kelamin: {jk[0]} | Kelas: {kelas[0]}");
            Console.WriteLine($"Nama: {nama[1]} | Jenis Kelamin: {jk[1]} | Kelas: {kelas[1]}");
            Console.WriteLine($"Nama: {nama[2]} | Jenis Kelamin: {jk[2]} | Kelas: {kelas[2]}");
        }
    }
}
