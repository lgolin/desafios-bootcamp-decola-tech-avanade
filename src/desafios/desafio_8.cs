  using System;

  class Program
  {
    static void Main(string[] args)
    {
      string[] vet = Console.ReadLine().Split(' ');
      //complete declarando as variáveis
      int a = Convert.ToInt32(vet[0]);
      int b = Convert.ToInt32(vet[1]);
      int c = Convert.ToInt32(vet[2]);
      int MAIOR = 0;

      if(a >= b && a >= c)
      {
        MAIOR = a;
      }
      else if(b >= a && b >= c)
      {
        MAIOR = b;
      }
      else
      {
        MAIOR = c;
      }

      Console.WriteLine($"{MAIOR} eh o maior");
                          
    }
  }