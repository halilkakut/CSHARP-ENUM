using System;

namespace CSHARP_ENUM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = 32;
            if(sıcaklık <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya Çıkmak için havanın ısınmasını bekleyin");
            else if(sıcaklık >= (int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarıya Çıkmak için hava çok sıcak bir gün");
            else if(sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.CokSıcak)
                Console.WriteLine("Hadi Dışarı çıkalım");
        }
    }

    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 27,
        CokSıcak = 35
    }
}
