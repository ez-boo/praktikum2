// See https://aka.ms/new-console-template for more information
//Nama  :Khoirul aryan perdana
//Nim   :22.11.4916
//Kelas :IF 06


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALKULATORConsoleApp
{
    class program
    {
        static void Main(string[] args)
        {   menu:
            Console.Title = "aplikasi Kalkulator";
            Console.WriteLine("Menu");
            Console.WriteLine("1.penjumlahan");
            Console.WriteLine("2.pengurangan");
            Console.WriteLine("3.perkalian");
            Console.WriteLine("4.pembagian");

            Console.Write("select ");

            int menu = Convert.ToInt32(Console.ReadLine());
            switch(menu)
            { case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("penjumlahan");
                        Console.Write("input a:");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("input b:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Hasil penjumlahan {0} + {1} = {2}", a, b, penjumlahan(a, b));
                        break;
                    }
                case 2:
                    {
                        Console.Clear();    
                        Console.WriteLine("pengurangan");
                        Console.Write("input a:");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("input b:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                        break;
  }

                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("perkalian");
                        Console.Write("input a:");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("input b:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("pembagian");
                        Console.Write("input a:");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("input b:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
                        break;
                    }
                    default: 
	                Console.WriteLine ("Invalid Input, please try again");
                    goto menu;
            }
        }
  static int penjumlahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}