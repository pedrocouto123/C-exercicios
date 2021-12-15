using System;
class HelloWorld {
  static void Main() {
    double a, b, c, d;
    
    Console.WriteLine("Digite um número:");
    a = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite outro número:");
    b = double.Parse(Console.ReadLine());
    
    c = Math.Pow(a, 2);
    d = Math.Pow(b , 3);
    
    Console.WriteLine(a + " elevado a 2 é " + c);
    Console.WriteLine(b + " elevado a 2 é " + d);
  }
}
