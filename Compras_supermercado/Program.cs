
using System;
using System.Linq;

class MinhaClasse
{
  public static void Main (string[] args) 
  {
    var totalDeCasosDeTeste = int.Parse(Console.ReadLine());

    for (int i = 0; i < totalDeCasosDeTeste; i++)
    {
        string [] lista = (Console.ReadLine()).Split();
        lista = lista.Distinct().ToArray();

        lista = lista.OrderBy(p => p).ToArray();
        Console.WriteLine("{0}", string.Join(" ", lista));
    }
  }
}