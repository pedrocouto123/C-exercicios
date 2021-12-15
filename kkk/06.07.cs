using System;
class HelloWorld {
  static void Main() {
    double a;
    
    Console.WriteLine("Digite um número:");
    a = double.Parse(Console.ReadLine());
    
    if(a > 5){
        Console.WriteLine("É maior que 5");
    }
    else{
        Console.WriteLine("É menor que 5");
    }
  }
}
