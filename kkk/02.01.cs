using System;
class HelloWorld {
  static void Main() {
    int n1, n2, d1, d2, nt_1, nt_2, nt, dt, m1, m2;
    Console.WriteLine("Primeira fração");
    
    Console.WriteLine("Digite o numerador:");
    n1 = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o denominador:");
    d1 = Int32.Parse(Console.ReadLine());
    
    
    
    
    Console.WriteLine("Segunda fração");
    
    Console.WriteLine("Digite o numerador:");
    n2 = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o denominador:");
    d2 = Int32.Parse(Console.ReadLine());
    
    /*Soma*/
    
    dt = d1 * d2;
    nt_1 = (d2 * n1);
    nt_2 = (d1 * n2);
    
    nt = nt_1 + nt_2;
    
    /*Produto*/
    
    m1 = n1 * n2;
    m2 = d1 * d2;
    
    Console.WriteLine("Produto das frações");
    Console.WriteLine("A fração é:" + m1 + "/" + m2);
    
    Console.WriteLine("Soma das frações");
    Console.WriteLine("A fração é: " + nt + "/" + dt);
  }
}
