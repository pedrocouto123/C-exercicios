using System;
class HelloWorld {
  static void Main() {
    double a , b, c, volume;  
      
    Console.WriteLine("Digite o comprimento:");
    a = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a largura:");
    b = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a altura");
    c = double.Parse(Console.ReadLine());
    
    volume = a * b * c;
    
    Console.WriteLine("O volume da caixa é: " + volume);
  }
}
