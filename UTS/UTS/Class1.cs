using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dosen dosen1 = new Dosen(281002, "Nugroho Priyo Utomo", 21114400, "Laki-laki", "Pemrograman");

            dosen1.cetakHasil();
            Console.WriteLine();
            dosen1.addDosen();
            dosen1.addCourse();
            Console.WriteLine();
            dosen1.cetakAkhir();

            Console.ReadKey();
        }
    }
}

