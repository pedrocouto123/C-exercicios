using System;
class HelloWorld {
  static void Main() {
    double a, b, c, delta, x1, x2, h; 
    Console.WriteLine("Digite o valor de A:");
    a = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o valor de B:");
    b = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o valor de C:");
    c = double.Parse(Console.ReadLine());
    
    h = Math.Pow(b, 2);
    delta = h - 4*a*c;
    
    d = Math.Pow(delta, 0.5);
    x1 = ((-1 * b) - d) / (2 * a);
    
    x2 = ((-1)*b) + d) / (2 * a);
    
    Console.WriteLine(x1);
    Console.WriteLine(x2);
  }
}
