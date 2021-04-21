using System; 

class minhaClasse {

    static void Main(string[] args) { 

        int num_testes = int.Parse(Console.ReadLine());

        //declare suas variaveis aqui   

        string[] n = Console.ReadLine().Split();
        int[] multiplier = new int [4];
        int number = 0;
        
        //continue a solução
        for (int i = 0; i < num_testes; i++)
        {
            number = int.Parse(n[i]);  
              
            if (number%2 == 0) multiplier[0] += 1;   
            if (number%3 == 0) multiplier[1] += 1;
            if (number%4 == 0) multiplier[2] += 1;      
            if (number%5 == 0) multiplier[3] += 1;
        } 

        
        Console.WriteLine("{0} Multiplo(s) de 2", multiplier[0]);
        Console.WriteLine("{0} Multiplo(s) de 3", multiplier[1]);
        Console.WriteLine("{0} Multiplo(s) de 4", multiplier[2]);
        Console.WriteLine("{0} Multiplo(s) de 5", multiplier[3]);
    }

}