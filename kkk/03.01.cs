using System;
class HelloWorld {
  static void Main() {
    double d, c; 
    Console.WriteLine("Digite a distância percorrida:");
    d = double.Parse(Console.ReadLine());
    
    c = d * 4.5;
    
    Console.WriteLine("O consumo de combustível é: " + c);
    
  }
}
