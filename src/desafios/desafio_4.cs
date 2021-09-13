using System; 

class minhaClasse {

  public static void Main()
  {
    int n;
    n = int.Parse(Console.ReadLine());
    //complete seu codigo
    for (int i = 0; i <= n; i++) //complete seu codigo
    {
      if(i % 2 == 1)
        Console.WriteLine(i);
    }
            
    Console.ReadLine();
  }

}