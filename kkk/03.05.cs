using System;
class HelloWorld {
  static void Main() {
    double j, p;  
    Console.WriteLine("Digite o valor da prestação:");
    p = double.Parse(Console.ReadLine());
    
    j = p + (p / 100);
    
    Console.WriteLine("O valor com juros é: " + j);
    
  }
}
