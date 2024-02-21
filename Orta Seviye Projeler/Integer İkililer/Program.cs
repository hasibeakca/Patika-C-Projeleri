using System.Collections;

namespace Integer_İkililer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Kaç adet sayı girmek istediğinizi belirtin : ");
            do
            {
               n = int.Parse(Console.ReadLine());
            } while (n % 2 != 0);

           int[] dizi = new int [n];
          
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz :" , i+1);
                int sayi = int.Parse(Console.ReadLine());
                dizi[i] = sayi;
            }   

            ArrayList yeniListe = new();
            for(int i = 0; i < n; i++)
            {
            
                
                    if (dizi[i].Equals(dizi[i + 1]))
                    {
                        int karesiAlinacak = dizi[i] * 2;
                        int kare = (int)Math.Pow(karesiAlinacak, 2);
                        yeniListe.Add(kare);

                    }
                    else if (!dizi[i].Equals(dizi[i + 1]))
                    {
                        int toplam =dizi[i] + dizi[i + 1];
                        yeniListe.Add(toplam);
                    }
                    
                    i++;
                
               
               
            }
            foreach(int i in yeniListe)
            {
                Console.WriteLine(i);
            }
        }
    }
}
