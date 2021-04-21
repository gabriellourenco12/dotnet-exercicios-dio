using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;
            for (int i = 1; i <= qtdTeste; i++) 
            {
                string[] valores = Console.ReadLine().Split();
                v1 = valores[0];
                v2 = valores[1];
                if(( v1.ToUpper() == "TESOURA" && v2.ToUpper() ==   "PAPEL" ) 
                    || ( v1.ToUpper() == "PAPEL" && v2.ToUpper() ==  "PEDRA" ) 
                    || ( v1.ToUpper() == "PEDRA" && v2.ToUpper() ==  "LAGARTO" ) 
                    || ( v1.ToUpper() == "LAGARTO" && v2.ToUpper() ==  "SPOCK" )
                    || ( v1.ToUpper() == "SPOCK" && v2.ToUpper() ==  "TESOURA" ) 
                    || ( v1.ToUpper() == "TESOURA" && v2.ToUpper() ==  "LAGARTO" )
                    || ( v1.ToUpper() == "LAGARTO" && v2.ToUpper() ==  "PAPEL" ) 
                    || ( v1.ToUpper() == "PAPEL" && v2.ToUpper() ==  "SPOCK" )
                    || ( v1.ToUpper() == "SPOCK" && v2.ToUpper() ==  "PEDRA" ) 
                    || ( v1.ToUpper() == "PEDRA" && v2.ToUpper() ==  "TESOURA" ))
                    Console.WriteLine("Caso #{0}: Bazinga!", i);                
                else if ( v1 == v2 )  
                    Console.WriteLine("Caso #{0}: De novo!", i);
                else
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }

    }

}