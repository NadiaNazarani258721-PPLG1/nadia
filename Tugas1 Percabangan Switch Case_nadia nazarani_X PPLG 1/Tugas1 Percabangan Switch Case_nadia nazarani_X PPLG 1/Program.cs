using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas1_Percabangan_Switch_Case_nadia_nazarani_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Untuk Mencari Luas Menggunakan Percabangan Switch Case ===");
            Console.Write("Menu Pilihan : ");
            Console.WriteLine("1. Luas Permukaan Kubus");
            Console.WriteLine("2. Volume Kubus");
            Console.WriteLine("3. Luas Permukaan Balok");
            Console.WriteLine("4. Volume Balok");
            Console.Write("Masukan Pilihan (1-4)  =  ");
            int pilihan = int.Parse(Console.ReadLine());
            
            switch (pilihan)
            {
                case 1: Console.Write("Masukan sisi Kubus    =  ");
                    int sisi = int.Parse(Console.ReadLine());
                    int rumus = 6 * sisi * sisi;
                    Console.WriteLine("Luas Permukaan Kubus  =  " + rumus);  break;
                case 2: Console.Write("Masukan sisi Kubus  =  ");
                    int si = int.Parse(Console.ReadLine());
                    int rm = si * si * si;
                    Console.WriteLine("Volume Kubus        =  " + rm);  break;
                case 3: Console.Write("Masukan panjang Balok  =  ");
                    int p = int.Parse(Console.ReadLine());
                    Console.Write("Masukan Lebar Balok        =  ");
                    int l = int.Parse(Console.ReadLine());
                    Console.Write("Masukan tinggi Balok       =  ");
                    int t = int.Parse(Console.ReadLine());
                    int rs = 2 * ((p * l) + (p * t) + (l * t));
                    Console.WriteLine("Luas Permukaan Balok   =  " + rs);  break;
                case 4: Console.Write("Masukan panjang Balok  =  ");
                    int pj = int.Parse(Console.ReadLine());
                    Console.Write("Masukan Lebar Balok        =  ");
                    int lb = int.Parse(Console.ReadLine());
                    Console.Write("Masukan tinggi Balok       =  ");
                    int tg = int.Parse(Console.ReadLine());
                    int rms = pj * lb * tg;
                    Console.WriteLine("Volume Balok           =  ");  break;
            }

        }
    }
}
