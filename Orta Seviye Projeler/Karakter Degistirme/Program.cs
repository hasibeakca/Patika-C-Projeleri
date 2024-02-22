using System.Collections;

namespace Karakter_Degistirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz : ");
            string cumle = Console.ReadLine();
            string[] cumleDizisi = cumle.Split(" ");
           string[] yeniDizi = new string[cumleDizisi.Length];
          for(int i = 0; i < cumleDizisi.Length; i++)
            {
 
                char [] harfDizisi = cumleDizisi[i].ToCharArray();
                char temp = harfDizisi[0];
                harfDizisi[0] = harfDizisi[harfDizisi.Length - 1];
              harfDizisi[harfDizisi.Length-1] = temp;
                    yeniDizi[i] = new string (harfDizisi);
            
            }
          foreach(string s in yeniDizi)
            {
                Console.Write(s + " ");
            }
           

         
        }
    }
}
