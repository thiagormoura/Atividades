using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite a base e a altura do retângulo:");
    float baseRet = float.Parse(Console.ReadLine());
    float alturaRet = float.Parse(Console.ReadLine());
    float area = baseRet * alturaRet;
    float perimetro = baseRet * 2 + alturaRet * 2;
    float diagonal = Math.Sqrt(baseRet ** 2 + alturaRet ** 2);
    Console.WriteLine("Àrea = {0:0.00}", area);
    Console.WriteLine("Perímetro = {0:0.00}", perimetro);
    Console.WriteLine("Diagonal = {0:0.00}", diagonal);
    
  }
}
