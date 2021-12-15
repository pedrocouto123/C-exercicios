using System;
class HelloWorld {
  static void Main() {
    double n1, n2, media, p1, p2;  
    Console.WriteLine("Digite a nota 1:");
    n1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Qual o peso dessa nota???");
    p1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a nota 2:");
    n2 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Qual o peso dessa nota???");
    p2 = double.Parse(Console.ReadLine());
    
    media = (n1*p1 + n2*p2) / (p1 + p2);
    
    Console.WriteLine("A média ponderada é: " + media);
  }
}
