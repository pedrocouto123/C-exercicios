using System;
class HelloWorld {
  static void Main() {
     double vendas, total; 
     Console.WriteLine("Digite o total de vendas do funcionário:");
     vendas = double.Parse(Console.ReadLine());
     
     total = vendas + (vendas * 5)/100;
     
     Console.WriteLine("O salario é: " + total);
    
  }
}
