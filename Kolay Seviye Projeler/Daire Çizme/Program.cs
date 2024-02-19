namespace Daire_Çizme
{
    using System;

    class Program
    {
        
        class Daire
        {
            private int yaricap;

            public Daire(int yaricap)
            {
                this.yaricap = yaricap;
            }

            public void DaireCiz()
            {
                
                for (int i = -yaricap; i <= yaricap; i++)
                {
                    for (int j = -yaricap; j <= yaricap; j++)
                    {
                        if (i * i + j * j <= yaricap * yaricap)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
       
            Console.Write("Dairenin yarıçapını girin: ");
            int kullaniciYaricap = Convert.ToInt32(Console.ReadLine());

            Daire daire = new Daire(kullaniciYaricap);

            daire.DaireCiz();
        }
    }

}
