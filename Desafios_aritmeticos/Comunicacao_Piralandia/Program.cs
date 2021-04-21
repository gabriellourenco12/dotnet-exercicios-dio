using System; 

class URI {

    static void Main(string[] args) { 

            string n = Console.ReadLine();
           
            string invertido = "";
            
            for (int i = n.Length; i > 0; i--) 
            {
              invertido += n[i-1];
            }
            
            Console.WriteLine(invertido + "\n");

    }

}