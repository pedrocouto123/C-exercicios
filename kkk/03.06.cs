using System;
class HelloWorld {
  static void Main() {
    double n1, n2, n3, soma, a, b, c, d;
    
    Console.WriteLine("Digite o primeiro número:");
    n1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o segundo número:");
    n2 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o terceiro número:");
    n3 = double.Parse(Console.ReadLine());
    
    a = Math.Pow(n1,2);
    b = Math.Pow(n2,2);
    c = Math.Pow(n3,2);
    
    d = a + b + c;
    
    Console.WriteLine("A soma do quadrado dos 3 números informados é: " + d);
    
  }
}
