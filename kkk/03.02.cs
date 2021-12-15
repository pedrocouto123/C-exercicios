using System;
class HelloWorld {
  static void Main() {
    double n1, n2;
    Console.WriteLine("Digite o primeiro número:");
    n1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o segundo número:");
    n2 = double.Parse(Console.ReadLine());
    
    n1 = n2;
    n2 = n1;
    
    Console.WriteLine(n1);
    Console.WriteLine(n2);
    
  }
}
