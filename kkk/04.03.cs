using System;
class HelloWorld {
  static void Main() {
    double lado1, lado2, lado3;
    
    Console.WriteLine("Digite o primeiro lado do triângulo:");
    lado1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o segundo lado do triângulo:");
    lado2 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o terceiro lado do triângulo:");
    lado3 = double.Parse(Console.ReadLine());
    
  
    
    if((lado1 < lado2 + lado3) && (lado2 < lado3 + lado1) && (lado3 < lado1 + lado2)){
       Console.WriteLine("É um triângulo"); 
    }
    else{
        Console.WriteLine("Não é um triângulo");
    }
    
    if((lado1 == lado2) && (lado2 == lado3) && (lado1 == lado3)){
        Console.WriteLine("Equilátero");
    }
    else if((lado1 == lado2) || (lado1 == lado3) || (lado2 == lado3)){
        Console.WriteLine("Isosceles");
    }
    else{
        Console.WriteLine("Escaleno");
    }
  }
}
