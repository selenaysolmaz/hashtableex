using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ConsoleApp1
{
    class hashtable
    {
        static void Main()
        {
            Hashtable Sozluk = new Hashtable();
            Sozluk.Add("araba", "car");
            Sozluk["kitap"] = "book";
            ICollection anahtarlar = Sozluk.Keys;
            foreach (string s in anahtarlar)
                Console.WriteLine(s);
            ICollection degerler = Sozluk.Values;
            foreach (string s in degerler)
                Console.WriteLine(s);
            Console.WriteLine("toplam kelime :" + Sozluk.Count);
            Console.ReadKey();
        }
      
    }
   
}
