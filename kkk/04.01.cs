using System;
class HelloWorld {
  static void Main() {
    double n;  
    Console.WriteLine("Digite um número:");
    n = double.Parse(Console.ReadLine());
    
    if(n >= 0 && n < 10){
        Console.WriteLine("O número informado está entre 0 e 10");
    }
    else if(n >= 10 && n < 20){
        Console.WriteLine("O número informado está entre 10 e 20");
    }
    else{
        Console.WriteLine("O número não pertence a nenhum intervalo");
    }
  }
}
