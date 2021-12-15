using System;
class HelloWorld {
  static void Main() {
    double n, b;
    
    Console.WriteLine("Digite um número:");
    n = double.Parse(Console.ReadLine());
    
    if(n < 0){
        b = n * (-1);
        Console.WriteLine(b);
    }
  }
}
