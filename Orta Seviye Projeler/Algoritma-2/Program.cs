using System.Collections;

namespace Algoritma_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayı girmek istersiniz ? ");
            int n = int.Parse(Console.ReadLine());
            ArrayList sayilar = new ArrayList();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz: ", i);
                int sayi = int.Parse(Console.ReadLine());
                sayilar.Add(sayi);
            }
            int kucuklerToplam = 0;
            int buyuklerToplam = 0;
            for(int i = 0; i < n; i++)
            {
                if ((int)sayilar[i] < 67)
                {
                    kucuklerToplam += 67 - (int)sayilar[i];
                }
                else if((int)sayilar[i] > 67)
                {
                    int sayi = 67 - (int)sayilar[i];
                  
                   sayi= Math.Abs(sayi);
                    int kareleri = (int)Math.Pow(sayi, 2);
                    buyuklerToplam += kareleri;
                    // Büyüğü küçükten çıkarıpda atabilirdik ama gönlünüz olsun abs yi kullanalım
                }
            }
            Console.WriteLine("67'den küçüklerin farklarının toplamı : {0}", kucuklerToplam);
            Console.WriteLine("67'den büyüklerin farklarının mutlak toplamı :  {0}", buyuklerToplam);
        }
    }
}
