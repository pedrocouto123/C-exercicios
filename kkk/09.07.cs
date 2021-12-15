using System;
class HelloWorld {
  static void Main() {
    int num, d1, d2, d3, d4;
    
    Console.WriteLine("Digite um número:");
    num = Int32.Parse(Console.ReadLine());
    
    d1 = (num/1000) % 10;
    d2 = (num/100) % 10;
    d3 = (num/100) % 10;
    d4 = num % 10;
    
    Console.WriteLine(" " + d1 + " " + d2 + " " + d3 + " " + d4);
  }
}
