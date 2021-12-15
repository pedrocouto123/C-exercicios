using System;
class HelloWorld {
  static void Main() {
    double a;
    
    Console.WriteLine("Digite um número:");
    a = double.Parse(Console.ReadLine());
    
    if(a > 5 && a < 10){
        Console.WriteLine("Entre 5 e 10");
        
    }
    else if(a > 0 && a < 5){
        Console.WriteLine("Entre 0 e 5");
    }
  }
}
