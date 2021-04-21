using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;

            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split();
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[4]);
    

            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split();
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[2]);
            segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[4]);
           

            int transformaSegundosInicio = (diaInicio * 3600 * 24 + horaMomentoInicio * 3600 + minutoMomentoInicio * 60 + segundoMomentoInicio);
            int transformaSegundosTermino = (diaTermino * 3600 * 24 + horaMomentoTermino * 3600 + minutoMomentoTermino * 60 + segundoMomentoTerminio);

            int somaTotalSegundos = (transformaSegundosTermino - transformaSegundosInicio);
            int W =  somaTotalSegundos/(60 * 60 * 24);
            somaTotalSegundos -= W*(60 * 60 * 24);  
            int X = (somaTotalSegundos)/(60 * 60);
            somaTotalSegundos -= X*(60 * 60);
            int Y = (somaTotalSegundos)/(60);
            somaTotalSegundos -= Y*60;
            int Z = (somaTotalSegundos);
          

            Console.WriteLine("{0} dia(s)", W);
            Console.WriteLine("{0} hora(s)", X);
            Console.WriteLine("{0} minuto(s)", Y);
            Console.WriteLine("{0} segundo(s)", Z);


    }

}