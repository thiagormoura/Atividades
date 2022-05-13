using System; 

public class Program {

  public static void Main(string[] args) {
  Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
  string b1 =Console.ReadLine();
  Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
  string b2 = Console.ReadLine();
  int n1=int.Parse(b1);
  int n2=int.Parse(b2);
  int bf =(n1*2 + n2*3)/5;
  Console.WriteLine("Nota final="+ bf);
}}
