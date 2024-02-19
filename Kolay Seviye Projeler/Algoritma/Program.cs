namespace Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir kelime ve bir sayı giriniz aralarını  ',' ile ayırınız: ");
            string veri = Console.ReadLine();
            string[] dizi = veri.Split(',');
            int silinecekIndex = Convert.ToInt32(dizi[1]);
            string yeniKelime;
            if (silinecekIndex > dizi[0].Length)
            {
                Console.WriteLine(dizi[0]);
            }
            else
            {
                 yeniKelime = dizi[0].Remove(silinecekIndex, 1);
                 Console.WriteLine(yeniKelime);
            }
          


        }
    }
}
