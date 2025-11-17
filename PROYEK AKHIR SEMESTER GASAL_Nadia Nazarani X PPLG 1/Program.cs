using System;

namespace PROYEK_AKHIR_SEMESTER_GASAL_Nadia_Nazarani_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args) // METHOD UTAMA
        {
            // Panggil method untuk menampilkan judul
            TampilkanJudul();

            // Input jumlah siswa 
            Console.Write("Masukkan jumlah siswa yang ingin diinput: ");
            int jumlahSiswa = Convert.ToInt32(Console.ReadLine());

            // Deklarasi array untuk menyimpan data siswa
            string[] namaSiswa = new string[jumlahSiswa];
            int[] absenSiswa = new int[jumlahSiswa];
            double[] nilaiMtkSiswa = new double[jumlahSiswa];
            double[] nilaiBindoSiswa = new double[jumlahSiswa];
            double[] nilaiBingSiswa = new double[jumlahSiswa];
            double[] nilaiPilSiswa = new double[jumlahSiswa];
            float[] kehadiranSiswa = new float[jumlahSiswa];
            bool[] statusLulus = new bool[jumlahSiswa];

            // === PERULANGAN UNTUK INPUT DATA SISWA DENGAN FOR ===
            for (int i = 0; i < jumlahSiswa; i++)
            {
                Console.WriteLine($"\n--------------------------- Data Siswa ke-{i + 1} ---------------------------");

                Console.Write("Masukkan nama siswa                         : "); // menggunakan tipe data string untuk nama
                namaSiswa[i] = Console.ReadLine();

                Console.Write("Masukkan nomor absen                        : "); // menggunakan tipe data int untuk nomor absen
                absenSiswa[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukkan nilai matematika siswa             : "); // menggunakan tipe data double untuk nilai
                nilaiMtkSiswa[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan nilai Bahasa Indonesia siswa       : "); // menggunakan tipe data double untuk nilai
                nilaiBindoSiswa[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan nilai Bahasa Inggris siswa         : "); // menggunakan tipe data double untuk nilai
                nilaiBingSiswa[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan nilai 1 mapel pilihan siswa        : "); // menggunakan tipe data double untuk nilai
                nilaiPilSiswa[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan persentase kehadiran (%)           : "); // menggunakan tipe data float untuk PERSENTASE kehadiran
                kehadiranSiswa[i] = float.Parse(Console.ReadLine());

                // variabel privat untuk memunculkan kerumus penghitungan kelulusan 
                double Wp = 0.70;  // Wp adalah bobot nilai pelajaran siswa (70%)
                double Wk = 0.30;  // Wk adalah bobot kehadiran siswa (30%)

                // Gunakan operator untuk menghitung dan menentukan kelulusan
                double RataRata = (nilaiMtkSiswa[i] + nilaiBindoSiswa[i] + nilaiBingSiswa[i] + nilaiPilSiswa[i]) / 4;
                double bobotNilai = (Wp * RataRata);
                double bobotKehadiran = (Wk * kehadiranSiswa[i]);
                double statusAkhir = bobotNilai + bobotKehadiran;

                Console.WriteLine("Jumlah Dari Perhitungan Bobot Nilai Dan Bobot Kehadiran : " + statusAkhir);

                // Percabangan mennggunakan if-else untuk menentukan kelulusan
                statusLulus[i] = HitungKelulusan(statusAkhir);

                if (statusLulus[i])
                {
                    Console.WriteLine("LULUS");
                }
                else
                {
                    // Jika tidak mencapai 75
                    Console.WriteLine("TIDAK LULUS");
                }

            }


            // === MENAMPILKAN SEMUA DATA SISWA ===
            TampilkanHasil(jumlahSiswa, namaSiswa, absenSiswa, nilaiMtkSiswa, nilaiBindoSiswa, nilaiBingSiswa, nilaiPilSiswa, kehadiranSiswa, statusLulus);

            Console.WriteLine("\nProgram selesai. Terima kasih!");
        }

        // === METHOD TAMBAHAN ===

        // Method 1: Menampilkan judul aplikasi
        static void TampilkanJudul()
        {
            Console.WriteLine("=== APLIKASI NILAI SISWA HASIL TES ===\n");
        }


        // Method 2 : Logika kelulusan
        static bool HitungKelulusan(double status)
        {
            // Mengembalikan true(benar) jika status lebih besar atau sama dengan 75 dan menampikan status "LULUS",
            // dan false(salah) jika kurang dari 75 dan menampilkan status "TIDAK LULUS".
            return (status >= 75);
        }


        // Method 3: Menampilkan hasil data siswa
        static void TampilkanHasil(int jumlahSiswa, string[] namaSiswa, int[] absenSiswa, double[] nilaiMtkSiswa, double[] nilaiBindoSiswa, double[] nilaiBingSiswa, double[] nilaiPilSiswa, float[] kehadiranSiswa, bool[] statusLulus) 
        {
            Console.WriteLine("\n=================================================================================================================================================");
            Console.WriteLine("                                                              DAFTAR HASIL SISWA                                                                 ");
            Console.WriteLine("=================================================================================================================================================");
            Console.WriteLine(" No | Nama Siswa     | Absen | Nilai Matematika | Nilai Bahasa Indonesia | Nilai Bahasa Inggris | Nilai Mapel Pilihan | Kehadiran | Status");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < jumlahSiswa; i++)
            {
                // Ambil status dari array boolean statusLulus
                string status = statusLulus[i] ? "LULUS" : "TIDAK LULUS";
                Console.WriteLine($"{i + 1,2} | {namaSiswa[i],-15} | {absenSiswa[i],5} | {nilaiMtkSiswa[i],16} | {nilaiBindoSiswa[i],22} | {nilaiBingSiswa[i],20} | {nilaiPilSiswa[i],19} | {kehadiranSiswa[i],8}% | {status}");
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
        }
    }
}
   