using System;
class HelloWorld {
  static void Main() {
    int n1, n2, d, a;  
    Console.WriteLine("Digite o primeiro número:");
    n1 = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o segundo número:");
    n2 = Int32.Parse(Console.ReadLine());
    
    d = n2 - n1;
    a = d * d;
    
    Console.WriteLine("O quadrado da diferença entre N2 e N1 é: " + a);
    
  }
}
