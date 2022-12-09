using System;
/*
 *          double u = polo / 2;
            double us = h / 2;
            double c = Math.Pow(u, 2) + Math.Pow(polo, 2);
            double w = Math.Sqrt(c);
            Console.WriteLine(w);
            double polovina =Math.Sqrt( Math.Pow(w, 2) - Math.Pow(h, 2));
            Console.WriteLine(polovina);
*/
namespace ukol5
{
    class vlastnosti
    {
        private static int a1;
        private static int a2;
        private static int b1;
        private static int b2;
        public int h;
        public vlastnosti(int A1, int A2, int B1, int B2)
        {
            a1 = A1;
            a2 = A2;
            b1 = B1;
            b2 = B2;
        }
        public int GetVlastnost1()
        {
            return a1;
        }
        public int GetVlastnost2()
        {
            return a2;
        }
        public int GetVlastnost3()
        {
            return b1;
        }
        public int GetVlastnost4()
        {
            return b2;
        }
        public void SETZměna_bodů()
        {
            Console.WriteLine("nastav souřadnici pro bod A \na1:");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("a2:");
            a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("nastav souřadnici pro bod B \nb1:");
            b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("b2:");
            b2 = int.Parse(Console.ReadLine());
        }
     
        public void Vzdalenost_bodů()
        {
            int a = a1 - a2;
            int b = b1 - b2;
            h = a + b;
            Console.WriteLine(a + b);
            if(h < 0)
            {
                h *= -1;
                
            }
            Console.WriteLine("vzdalenost mezi dvouma body");
            Console.WriteLine(h);
            
     
           
        }
        public void Výpočet_obsahu_obdelniku()
        {
            int a = Math.Sqrt(Math.Pow(a1 - a2,2));
            int b = Math.Sqrt(Math.Pow(b1 - b2,2));
            int a3 = Math.Sqrt(Math.Pow(a1 - b2,2));
            int b3 = Math.Sqrt(Math.Pow(b1 - a2,2));
            Console.WriteLine("bod první je na souřadnicích [" + a1+ ","  + b2 + "]");
            Console.WriteLine("bod druhý je na souřadnicích [" + b1 + "," + a2 + "]");
            double Ab = Math.Sqrt(Math.Pow(a - a3,2));
            double Ba = Math.Sqrt(Math.Pow(a - b3,2));
            
            double obsah = Ab * Ba;
            Console.WriteLine("obsah obdelníku je : " + obsah);




        }
        public void Výpočet_obsahu_kružnice()
        {
            Console.WriteLine("obsah kružnice z bodu A a poloměrem B");
            double f = 3.14 * Math.Pow(h, 2);
            Console.WriteLine("obsah kruhu je " + f);
        }
        public void Výpočet_trojuhelníku()
        {
            int b = b1 - b2;
            int a = a1 - a2;
            double AC = Math.Sqrt(Math.Pow(a, 2));
            double BC = Math.Sqrt(Math.Pow(b, 2));
            double obsah = AC * BC * h;
            Console.WriteLine("obsah kruhu kde bod C [0,0]" + obsah);

        }

        public void Výpis_bodů_roviny()
        {
            int x_init=a1;
            int y_init= b1;
           
               for(int y = 0; y <= Math.Abs(a2-b2); y++)
               {
                  for(int i = 0;  i <= Math.Abs(a1-b1);i++)
                  {
                      Console.Write("bod A ma souřadnice [" + a1 +i  + "," + a2-y + "]");
                  }
                  Console.Writeline();
               }
               
            
            public string Setjmeno()
            {
              return co cheš vratit jakože to co maš uložené ;
            }

            
        }

        public void vypis()
        {
            Console.WriteLine("bod A ma souřadnice [" + a1 + "," + a2 + "]");
            Console.WriteLine("bod B ma souřadnice [" + b1 + "," + b2 + "]");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            vlastnosti body = new vlastnosti(2, 3,4 , 2);
            body.Vzdalenost_bodů();
            body.Výpis_bodů_roviny();
            bool restart = true;
            while (restart = true)
            {

               


                Console.WriteLine("přeješ si změnit body? (stiskni 1)");
                int j = int.Parse(Console.ReadLine());
                if (j == 1)
                {
                    body.SETZměna_bodů();
                }

            }
        }
    }
}
