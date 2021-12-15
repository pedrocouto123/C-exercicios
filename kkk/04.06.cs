using System;
class HelloWorld {
  static void Main() {
    double a, b, sub;
    
    Console.WriteLine("Digite o primeiro número:");
    a = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o segundo número:");
    b = double.Parse(Console.ReadLine());
    
    if(a > b){
        sub = a - b;
        Console.WriteLine(sub);
    }
    else if(b > a){
        sub = b - a;
        Console.WriteLine(sub);
    }
  }
}
