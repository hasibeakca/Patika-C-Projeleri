namespace Sessiz_Harf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle yazınız :");
            string cumle = Console.ReadLine().Trim();
            string [] cumleDizi = cumle.Split(" ");
            for(int i = 0; i < cumleDizi.Length; i++)
            {
                char[] harfDizisi = cumleDizi[i].ToCharArray();
                Console.WriteLine(Kontrol(harfDizisi));
            }

        }

        public static bool Kontrol(char[] harfDizisi)
        {
            char[] sesliHarfler = new char[8] { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
            for(int i = 0;i < harfDizisi.Length -1;i++)
            {
                if (!(sesliHarfler.Contains(harfDizisi[i])) && (!sesliHarfler.Contains(harfDizisi[i + 1])))
                {
                    return true;
                }
               
            }
            return false;
        }
    }
}
