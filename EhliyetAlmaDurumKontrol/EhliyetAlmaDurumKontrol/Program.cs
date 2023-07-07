using System;
using System.ComponentModel;

namespace EhliyetAlmaDurumKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan isim, yaş ve eğitim bilgilerini isteyip ehliyet alabilme 
            // durumunu kontrol ediniz.
            // Ehliyet alma koşulu en az 18 ve eğitim durumu 
            // lise ya da üniversite olmalıdır. 

            Console.Write("İsminizi girin :");
            string ad = Console.ReadLine();

            Console.Write("Yaşını girin :");
            int yas = int.Parse(Console.ReadLine());

            Console.Write("Eğitim bilginizi girin :");
            string ebilgi = Console.ReadLine();

            if(yas >=18 && (ebilgi== "lise" || ebilgi == "universite"))
            {
                Console.WriteLine($"Tebrikler {ad}. Ehliyet alabilirsin.");
            }
            else
            {
                Console.WriteLine($"Üzgünüm {ad} gerekli kriterlere sahip değilsin. ");
            }

        }
    }
}
