using System;
class HelloWorld {
  static void Main() {
    double salario, taxa;
    
    Console.WriteLine("Digite seu salário:");
    salario = double.Parse(Console.ReadLine());
    
    taxa = salario + (salario * 5)/100;
    
    Console.WriteLine("Seu salario é: " + taxa);
  }
}
