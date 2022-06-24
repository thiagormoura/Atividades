using System; 

public class Program {

  public static void Main(string[] args) {
     Console.WriteLine("Digite senha");
    int senha = int.Parse (Console.ReadLine());
   
   while (senha !=2002) {
   Console.WriteLine("negado");
 };
    while (senha ==2002) {
   Console.WriteLine("permitido");
 };

}}