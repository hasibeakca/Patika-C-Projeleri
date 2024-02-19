namespace Fibonacci_Ortalama_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> list = new();
            int a = 1;
            int b = 1;
            int c;
            Console.WriteLine("Derinlik ne kadar olsun?");
            int derinlik = int.Parse(Console.ReadLine());
            list.Add(a);
            list.Add(b);
            for (int i = 0; i < derinlik -2; i++)
            {
                c = a + b;
                a = b;
                b = c;
                list.Add(c);
            }
            int toplam = 0;
            foreach (int i in list)
            {
                toplam += i;
                Console.WriteLine(i);
            }
            double ortalama = (double)toplam / derinlik;
            Console.WriteLine("Fibonacci sayılarınınn {0} derinlikte ortalaması : {1}", derinlik, ortalama);
        }
    }
}
