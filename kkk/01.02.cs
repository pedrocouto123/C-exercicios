using System;
class HelloWorld {
  static void Main() {
    double f, c;  
      
    Console.WriteLine("Digite a temperatura em Fahrenheit:");
    f = double.Parse(Console.ReadLine());
    
    c = (5 * (f - 32)) / 9;
    
    Console.WriteLine("A temperatura em graus celsius é:" + c);
  }
}
