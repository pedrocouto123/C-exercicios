using System;
class HelloWorld {
  static void Main() {
    double d, c;  
    Console.WriteLine("Digite a distância percorrida:");
    d = double.Parse(Console.ReadLine());
    
    c = d * 4;
    
    Console.WriteLine("A distância percorrida é: " + d);
    Console.WriteLine("O consumo de combustível é: " + c);
  }
}
