using System;
class HelloWorld {
    double n1, n2, soma, sub, mult, div;
    
    Console.WriteLine("Digite o primeiro número:");
    n1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o segundo número:");
    n2 = double.Parse(Console.ReadLine());
    
    soma = n1 + n2;
    sub = n1 - n2;
    mult = n1 * n2;
    div = n1 * n2;
    
    Console.WriteLine("A soma é: " + soma);
    Console.WriteLine("A subtração é: " + sub);
    Console.WriteLine("A multiplicação é: " + mult);
    Console.WriteLine("A divisão é: " + div);
  }
}
