using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public class ClassRef
    {
        public void RunRef()
        {
            int nilai = 10;
            Console.WriteLine("Nilai sebelum pemanggilan metode: " + nilai);

            // Panggil metode dengan parameter ref
            ModifikasiNilai(ref nilai);

            // Value variable nilai berubah, padahal tidak ada assign value ke nilai ini dikarnakan ref
            Console.WriteLine("Nilai setelah pemanggilan metode: " + nilai);
        }

        private static void ModifikasiNilai(ref int x)
        {
            // Modifikasi nilai variabel yang dilewatkan sebagai parameter ref
            x = 20;
        }
    }
}
