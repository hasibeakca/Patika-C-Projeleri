namespace Karakter_Tersten_Yazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İstediğiniz cümleyi giriniz : ");
            string cumle = Console.ReadLine();
            char[] karakterler = cumle.ToCharArray();
            for (int i = 1; i < karakterler.Length; i++)
            {
                char temp = karakterler[i];
                karakterler[i] = karakterler[i - 1];
                karakterler[i - 1] = temp;
                i++;
            }
            if(karakterler.Length %2 != 0)
            {
                karakterler[karakterler.Length - 1] = karakterler[karakterler.Length - 2];
            }
            foreach (char c in karakterler)
            { Console.Write(c); }
        }
    }
}
