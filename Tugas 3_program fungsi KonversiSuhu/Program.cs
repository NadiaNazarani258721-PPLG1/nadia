using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_3_program_fungsi_KonversiSuhu
{
    internal class Program
    {
        static int KonversiSuhu(int c)
        {
            int rm = (c * 9 / 5) + 32;
            return rm;
        }
        static void Main(string[] args)
        {
            Console.Write("Masukan suhu celcius yang akan dirubah ke fahrenhait  :  ");
            int x = Convert.ToInt32(Console.ReadLine());

            int hasil = KonversiSuhu(x);
            Console.WriteLine("nilai hasil konversi suhu dari celcius ke fahrenhait  :  " + hasil + "°F");


        }
    }
}

