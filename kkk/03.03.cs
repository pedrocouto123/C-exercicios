using System;
class HelloWorld {
  static void Main() {
    double bas, alt, area;  
    Console.WriteLine("Digite a base do triângulo:");
    bas = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a altura do triângulo:");
    alt = double.Parse(Console.ReadLine());
    
    area = (bas * alt) / 2;
    
    Console.WriteLine("A Area do triângulo é: " + area);
    
  }
}
