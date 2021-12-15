using System;
class HelloWorld {
  static void Main() {
    double salario, r;
    
    Console.WriteLine("Digite o salario:");
    salario = double.Parse(Console.ReadLine());
    
    r = salario + ((salario * 5) / 100);
    
    Console.WriteLine("O salário com o reajuste é: " + r);
  }
}
