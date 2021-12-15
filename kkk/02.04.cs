using System;
class HelloWorld {
  static void Main() {
    double n1, n2, n3, n4, media;
    
    Console.WriteLine("Digite a nota 1;");
    n1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a nota 2:");
    n2 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a nota 3;");
    n3 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a nota 4:");
    n4 = double.Parse(Console.ReadLine());
    
    media = 4 * (1/n1 + 1/n2 + 1/n3 + 1/n4);
    
    Console.WriteLine("A média harmônica é: " + media);
  }
}
