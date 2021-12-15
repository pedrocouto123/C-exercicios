using System;
class HelloWorld {
  static void Main() {
    double n1, n2, soma;
    Console.WriteLine("Digite um número:");
    n1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite outro número:");
    n2 = double.Parse(Console.ReadLine());
    
    soma = n1 + n2;
    
    if(soma > 10){
        Console.WriteLine("A soma é maior que 10");
    }
    else{
        Console.WriteLine("A soma é menor que 10");
    }
  }
}
