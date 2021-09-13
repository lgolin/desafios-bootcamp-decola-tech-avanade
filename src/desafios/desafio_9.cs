using System;

class ValidacaoDeNota 
{  
  public static void Main() 
  {
      
    double somaDasNotas = 0;
    int contador = 0;
      
    do
    {
      double notaEntrada = double.Parse(Console.ReadLine());
        
      if (notaEntrada < 0 || notaEntrada > 10)
      {
        Console.WriteLine("nota invalida");
      } 
      else
      {
        contador++;
        somaDasNotas += notaEntrada; 
      }    
    } 
    while (contador < 2);
      
    Console.WriteLine("media = " + (somaDasNotas / 2).ToString("N2"));
  }
}