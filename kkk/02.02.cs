using System;
class HelloWorld {
  static void Main() {
    double vendas, salario;
    
    Console.WriteLine("Digite o total das vendas do mês:");
    vendas = double.Parse(Console.ReadLine());
    
    salario = ((5 * vendas) / 100) + 1000;
    
    Console.WriteLine("O salário do vendedor é: " + salario);
  }
}
