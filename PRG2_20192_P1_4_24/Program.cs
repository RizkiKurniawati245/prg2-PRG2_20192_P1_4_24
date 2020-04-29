using System;

namespace PRG2_20192_P1_4_24
{
    class Program
    {
        static void Main(string[] args)
        {
            float Alas, Tinggi, Luas;
            double Hipotenusa, Keliling;
            int pilih;
            menu:
            Console.WriteLine("MENU SEGITIGA SIKU-SIKU");
            Console.WriteLine("a. Hitung Luas");
            Console.WriteLine("b. Hitung Hipotenusa");
            Console.WriteLine("c. Hitung Keliling");
            Console.WriteLine("d. Keluar");
            Console.Write("Masukkan pilihan [1, 2, 3, 4] : ");
            pilih = Convert.ToInt16(Console.ReadLine());
            switch (pilih)
            {
                case 1 :
                        Console.Clear();
                        Console.WriteLine("\n *** Hitung Luas *** \n");
                        Console.Write("Masukkan alas : ");
                        Alas = Convert.ToSingle(Console.ReadLine());

                        Console.Write("Masukkan tinggi : ");
                        Tinggi = Convert.ToSingle(Console.ReadLine());

                        Luas = Alas * Tinggi / 2;

                        Console.WriteLine("Luas segitiga dengan alas " + Alas + " dan tinggi " + Tinggi + " adalah " + Luas + " satuan");
                        Console.ReadKey();
                        Console.Clear();
                        goto menu;

                case 2:
                        Console.Clear();
                        Console.WriteLine("\n *** Hitung Hipotenusa ***\n");
                        Console.Write("Masukkan alas : ");
                        Alas = Convert.ToSingle(Console.ReadLine());

                        Console.Write("Masukkan tinggi : ");
                        Tinggi = Convert.ToSingle(Console.ReadLine());

                        Hipotenusa = Math.Sqrt(Alas*Alas + Tinggi*Tinggi);

                        Console.WriteLine("Hipotenusa adalah " + Hipotenusa);
                        Console.ReadKey();
                        Console.Clear();
                        goto menu;

                case 3:
                        Console.Clear();
                        Console.WriteLine("\n *** Hitung Keliling ***\n");
                        Console.Write("Masukkan alas : ");
                        Alas = Convert.ToSingle(Console.ReadLine());

                        Console.Write("Masukkan tinggi : ");
                        Tinggi = Convert.ToSingle(Console.ReadLine());

                        Hipotenusa = Math.Sqrt(Alas * Alas + Tinggi * Tinggi);
                        Keliling = Alas + Tinggi + Hipotenusa;

                        Console.WriteLine("Hipotenusa : " + Hipotenusa);
                        Console.WriteLine("Keliling adalah " + Keliling);
                        Console.ReadKey();
                        Console.Clear();
                        goto menu;

                case 4:
                        Console.Clear();
                        Console.WriteLine("Thank You :)");
                        break;

                default:
                        Console.Clear();
                        goto menu;
            }
        }
    }
}
