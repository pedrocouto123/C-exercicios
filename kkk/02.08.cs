using System;
class HelloWorld {
  static void Main() {
    double a, b;  
    Console.WriteLine("Digite um número:");
    a = double.Parse(Console.ReadLine());
    
    b = Math.Pow(a, 2);
    
    Console.WriteLine("O resultado é: " + b);
    
  }
}
