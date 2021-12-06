using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum_W13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jalan = 0;
            Console.Write("Berapa Data = ");
            var berapa = Convert.ToInt32(Console.ReadLine());
            string[,] printHasil = new string[berapa, 7];
            int cek = 0;
            while (jalan == 0)
            {
                for (int i = 0; i < berapa; i++)
                {
                    cek++;
                    Console.WriteLine($"Data ke - {i + 1}");
                    Console.Write("NIM            : ");
                    printHasil[i, 0] = Console.ReadLine();
                    if (cek > 1)
                    {
                        while (printHasil[i, 0] == (printHasil[i, 0]))
                        {
                            Console.WriteLine("NIM SUDAH ADA, MASUKKAN NIM LAIN!");
                            printHasil[i, 0] = Console.ReadLine();
                        }
                    }
                    Console.Write("NAMA           : ");
                    printHasil[i, 1] = Console.ReadLine();
                    Console.Write("JENIS KELAMIN  : ");
                    printHasil[i, 2] = Console.ReadLine();
                    Console.Write("TAHUN MASUK    : ");
                    printHasil[i, 3] = Console.ReadLine();
                    Console.Write("PROGRAM STUDI  : ");
                    printHasil[i, 4] = Console.ReadLine();
                    Console.Write("KELAS          : ");
                    printHasil[i, 5] = Console.ReadLine();
                    Console.WriteLine();

                }
                Console.WriteLine("PRINT HASIL ? (y/n)");
                string ulang = Console.ReadLine();
                if (ulang == "y")
                {
                    Console.Clear();
                    var nyetak = new System.Text.StringBuilder();
                    Console.WriteLine(String.Format("{0,-5} {1,-10} {2,-20} {3,-25} {4,-15} {5,-20} {6,-20}", "NO", "NIM", "NAMA", "JENIS KELAMIN", "TAHUN MASUK", "PROGRAM STUDI", "KELAS"));
                    for (int i = 0; i < berapa; i++)
                    {
                        Console.WriteLine(String.Format("{0,-5} {1,-10} {2,-20} {3,-25} {4,-15} {5,-20} {6,-20}", (i + 1), printHasil[i, 0], printHasil[i, 1], printHasil[i, 2], printHasil[i, 3], printHasil[i, 4], printHasil[i, 5]));
                    }
                }
                else if (ulang == "n")
                {
                    
                }
                Console.Write("Tambah Data? (y/n) ...");
                var tambah = Console.ReadLine();
                if (tambah == "n")
                {
                    jalan = 1;
                }
                else if (tambah == "y")
                {
                    jalan = 0;
                }
            }
        }
    }
}
