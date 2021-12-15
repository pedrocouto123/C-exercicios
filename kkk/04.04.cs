using System;
class HelloWorld {
  static void Main() {
    double n1, n2, sub;  
    Console.WriteLine("Digite um número:");
    n1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite outro número:");
    n2 = double.Parse(Console.ReadLine());
    
    if(n1 > n2){
        sub = n1 - n2;
        Console.WriteLine("A diferença é: " + sub);
    }
    else if(n2 > n1){
        sub = n2 - n1;
        Console.WriteLine("A diferença é: " + sub);
    }
    else{
        Console.WriteLine("Os números são iguais");
    }
  }
}
