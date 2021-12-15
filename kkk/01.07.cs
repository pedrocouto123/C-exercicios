using System;
class HelloWorld {
  static void Main() {
    int n1, n2, n3, n4;
    int a, b, c, d, e, f, g, h, i, j;
    
    Console.WriteLine("Digite o primeiro número:");
    n1 = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o segundo número:");
    n2 = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o terceiro número:");
    n3 = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o quarto número:");
    n4 = Int32.Parse(Console.ReadLine());
    
    a = n1 + n2;
    b = n1 + n3;
    c = n1 + n4;
    d = n2 + n3;
    e = n3 + n4;
    
    f = n1 * n2;
    g = n1 * n3;
    h = n1 * n4;
    i = n2 * n3;
    j = n3 * n4;
    
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
    Console.WriteLine(e);
    
    Console.WriteLine(f);
    Console.WriteLine(g);
    Console.WriteLine(h);
    Console.WriteLine(i);
    Console.WriteLine(j);
    
    
  }
  
}
