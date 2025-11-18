using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_konversi_mata_uang_nadia_nazarani_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM UNTUK MENGKONVERSI MATA UANG ===");

            Console.Write("Masukan mata uang rupiah  =  ");
            int r = Convert.ToInt32(Console.ReadLine());
            int KursUSD = 16_635;
            int KursGBP = (int)22_323.80;
            int KursJPY = 112_31;
            int KursSAR = (int)4_416.86;

            double usd = r / KursUSD;
            double gbp = r / KursGBP;
            double jpy = r / KursJPY;
            double sar = r / KursSAR;

            Console.WriteLine("============================================");
            Console.WriteLine("Mata Uang Rupiah          =  " + "Rp"  + r);
            Console.WriteLine("Ke Dolar USD              =  " + "$"   + usd);
            Console.WriteLine("Ke Poundsterling Inggris  =  " + "£"   + gbp);
            Console.WriteLine("Ke Yen Jepang             =  " + "¥"   + jpy);
            Console.WriteLine("Ke Riyal Saudi            =  " + "?.?" + sar);
        }
    }
}
