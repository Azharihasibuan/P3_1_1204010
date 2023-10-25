using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P3_1_1204010
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.Write("Menentukan Indeks Prestasi Mahasiswa\n----------------------");
                Console.Write("\nMasukan Nama Mahasisawa:");

                string nama = Console.ReadLine();

                Console.WriteLine("Masukan Nilai    :");
                int nilai = Convert.ToInt16(Console.ReadLine());

                String[] grade = { "A", "B", "C", "D" };

                if (nilai >= 85)
                {
                    Console.WriteLine("Indeks Nilai {0} adalah {1}", nama, grade[0]);
                }
                else if (nilai >= 70 && nilai < 85)
                {
                    Console.WriteLine("Indeks Nilai { 0} adalah { 1}", nama, grade[1]);
                }
                else if (nilai >= 60 && nilai < 70)
                {
                    Console.WriteLine("Indeks Nilai { 0} adalah { 1}", nama, grade[2]);

                }
                else
                {
                    Console.WriteLine("Indeks Nilai { 0} adalah { 1}", nama, grade[3]);


                }
                Console.Write("\nMasukan Indeks yang ditampilkan  :");
                char indeks = Convert.ToChar(Console.ReadLine());
                Console.Write("Indeks prestasi {0} adalah", nama);

                prestasi(indeks);

                Console.Write("\nIngin mengulang kembali (Y/T)");

            }
            while (Console.ReadLine() == "Y");
            }


        private static void prestasi (char indeks)
        {
            switch(indeks)
            {
                case 'A':
                    Console.WriteLine("sangat baik");
                    break;
                case 'B':
                    Console.WriteLine("sangat baik");
                    break;
                case 'C':
                    Console.WriteLine("sangat baik");
                    break;
                case 'D':
                    Console.WriteLine("sangat baik");
                    break;
                default:
                    Console.WriteLine("Invalid indeks prestasi");
                    break;
            }
        }
}



}
