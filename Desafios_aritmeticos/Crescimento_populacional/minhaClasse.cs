using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                string[] valores = (Console.ReadLine().Replace(".",",")).Split();
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

               //declare as variaveis corretamente
                cpa = (double.Parse(valores[2]))/100;
                cpb = (double.Parse(valores[3]))/100;

                while (pa <= pb)
                {
                  pa = (int)(Math.Floor(pa*(1+cpa)));
                  pb = (int)(Math.Floor(pb*(1+cpb)));
                  anos++;

                   //complete o while

                    if (anos > 100)
                    {
                       //complete a condicional
                       break;
                    }
                }

                if (anos <= 100)
                {
                   //complete a condicional
                   Console.WriteLine("{0} anos",anos);
                }
                else
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }

            }

    }

}