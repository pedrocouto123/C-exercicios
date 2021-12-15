using System;
class HelloWorld {
  static void Main() {
    double a, b, c;
    Console.WriteLine("Digite um número:");
    a = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o expoente da potência:");
    b = double.Parse(Console.ReadLine());
    
    c = Math.Pow(a, b);
    
    Console.WriteLine("O resultado é: " + c);
  }
}
