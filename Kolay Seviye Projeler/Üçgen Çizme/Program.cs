namespace Üçgen_Çizme
{
    using System;

    class Program
    {
       
        class Ucgen
        {
           
            private int boyut;

            
            public Ucgen(int boyut)
            {
                this.boyut = boyut;
            }

            
            public void UcgenCiz()
            {
               
                for (int i = 1; i <= boyut; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }

      
        static void Main(string[] args)
        {
           
            Console.Write("Üçgenin boyutunu girin: ");
            int kullaniciBoyut = Convert.ToInt32(Console.ReadLine());

           
            Ucgen ucgen = new Ucgen(kullaniciBoyut);

           
            ucgen.UcgenCiz();
        }
    }

}
