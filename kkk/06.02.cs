using System;
class HelloWorld {
  static void Main() {
    double n1,n2,soma;  
    Console.WriteLine("Digite um número:");
    n1 = double.Parse(Console.ReadLine());
    
    
    Console.WriteLine("Digite um número:");
    n2 = double.Parse(Console.ReadLine());
    
    soma = n1 + n2;
    if(soma > 10){
        soma = soma + 5;
        Console.WriteLine(soma);
    }
    else if(soma < 10){
        soma = soma + 7;
        Console.WriteLine(soma);
    }
  }
}
