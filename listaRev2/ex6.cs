using System; 

public class Program {

  public static void Main(string[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    if(a <= b && a <= c && b <= c) Console.WriteLine(a + c);
    else if(b <= c <= a) Console.WriteLine(b + a);
    else if(c <= a <= b) Console.WriteLine(c + b);
    
  }
}