using System;
class HelloWorld {
  static void Main() {
    double a, b, c;
    
    Console.WriteLine("Digite o primeiro lado:");
    a = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o segundo lado:");
    b = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o terceiro lado:");
    c = double.Parse(Console.ReadLine());
    
    if((a < b + c) && (b < a + c) && (c < a + b)){
        Console.WriteLine("É um triângulo");
    }
    else{
        Console.WriteLine("Não é um triângulo");
    }
    
    if(a < b && b < c){
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
    else if(b < c && c < a){
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(a);
    }
    
  }
}
