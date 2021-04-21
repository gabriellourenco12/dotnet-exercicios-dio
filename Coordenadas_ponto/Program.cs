using System; 

class URI {

    static void Main(string[] args) 
    { 
      //implemente sua solução aqui
      
      string[] valores = (Console.ReadLine()).Split();
      double x = double.Parse(valores[0]);
      double y = double.Parse(valores[1]);
      
      if (x == 0 || y == 0)
      {
        if (x == y) Console.WriteLine("Origem");
        else if (x == 0) Console.WriteLine("Eixo Y");
        else Console.WriteLine("Eixo X");
      }
      else if (x > 0)
      {
        if (y > 0) Console.WriteLine("Q1");
        else Console.WriteLine("Q4");
      }
      else
      {
        if (y > 0) Console.WriteLine("Q2");
        else Console.WriteLine("Q3");
      }

    }

}