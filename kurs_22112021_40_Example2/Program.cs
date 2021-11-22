using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace kurs_22112021_40_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList'te tip yok
            ArrayList listem = new ArrayList();
            listem.Add("Faik");
            listem.Add("Turan");
            listem.Add("123456789");
            listem.Add('E');
            listem.Add(20);

            listem.Add("Esra");
            listem.Add("Turan");
            listem.Add("123456789");
            listem.Add('K');
            listem.Add(20);

            listem.Add("Arif");
            listem.Add("Turan");
            listem.Add("123456789");
            listem.Add('K');
            listem.Add(20);

            Console.WriteLine("Array List oluşturuldu.");
            Console.WriteLine("Yazdırılıyor...");
            Thread.Sleep(1000);
            Console.Clear();

            foreach (var item in listem)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Array List kapasitesi: "+listem.Capacity);

            listem.Remove("Faik");
            int[] l = new int[5];
            foreach (var item in listem.ToArray())
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
