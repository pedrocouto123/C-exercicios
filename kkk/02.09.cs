using System;
class HelloWorld {
  static void Main() {
    double l, a;  
    Console.WriteLine("Digite o lado do quadrado:");
    l = double.Parse(Console.ReadLine());
    
    a = Math.Pow(l, 2);
    
    Console.WriteLine("A area é:" + a);
    
  }
}
