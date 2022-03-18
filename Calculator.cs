using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char nomor;
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("CALCULATOR");
            Console.WriteLine("Penambahan");
            Console.WriteLine("Pengurangan");
            Console.WriteLine("Perkalian");
            Console.WriteLine("Pembagian");
            Console.Write("Pilih Fitur Apa Yang Akan Digunakan (1-4)= ");
            nomor = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n");

            if ( nomor == '1')
            {
                Console.WriteLine("Penambahan");
                Console.WriteLine("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); // proses casting

                Console.WriteLine("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); // proses casting

                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }
           else if ( nomor == '2')
            {
                Console.WriteLine("Pengurangan");
                Console.WriteLine("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); // proses casting

                Console.WriteLine("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); // proses casting

                Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b)); 
            }
          else  if ( nomor == '3')
            {
                Console.WriteLine("Perkalian");
                Console.WriteLine("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); // proses casting

                Console.WriteLine("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); // proses casting

                Console.WriteLine("Hasil Perkalian " + a + " x " + b + " = " + Perkalian(a, b));
            }
           else if ( nomor == '4')
            {
                Console.WriteLine("Pembagian");
                Console.WriteLine("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); // proses casting

                Console.WriteLine("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); // proses casting

                Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf Menu Yang Anda Pilih Tidak Tersedia");
            }
           
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
        

        // TODO: tambahkan method untuk Perkalian dan Pembagian
    }
}
