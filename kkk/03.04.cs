using System;
class HelloWorld {
  static void Main() {
    double f,c;  
    Console.WriteLine("Digite a temperatura na escala Fahrenheit:");
    f = double.Parse(Console.ReadLine());
    
    c = (5 * (f - 32)) / 9;
    
    Console.WriteLine("A temperatura na escala Celsius é: " + c);
    
  }
}
