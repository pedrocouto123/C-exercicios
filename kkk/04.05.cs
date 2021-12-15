using System;
class HelloWorld {
  static void Main() {
    int a, b, c, d;
    
    Console.WriteLine("Digite o primeiro número:");
    a = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o segundo número:");
    b = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o terceiro número:");
    c = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o quarto número:");
    d = Int32.Parse(Console.ReadLine());
    
    if(a%2 == 0){
        Console.WriteLine("O primeiro número é divisel por 2");
    }
    if(b%2 == 0){
        Console.WriteLine("O segundo número é divisel por 2");
    }
    if(c%2 == 0){
        Console.WriteLine("O terceiro número é divisel por 2");
    }
    if(d%2 == 0){
        Console.WriteLine("O quarto número é divisel por 2");
    }
    
    if(a%3 == 0){
        Console.WriteLine("O primeiro número é divisel por 3");
    }
    if(b%3 == 0){
        Console.WriteLine("O segundo número é divisel por 3");
    }
    if(c%3 == 0){
        Console.WriteLine("O terceiro número é divisel por 3");
    }
    if(d%3 == 0){
        Console.WriteLine("O quarto número é divisel por 3");
    }
    
  }
}
