using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite três números:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int soma = a + b + c;
    int menor = Math.Min(a, b);
    menor = Math.Min(menor, c);
    soma = soma - menor;
    Console.WriteLine($"A soma dos dois maiores é {soma}");
     
  }
}