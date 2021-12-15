using System;
class HelloWorld {
  static void Main() {
    int n, custo;  
    Console.WriteLine("Digite o numero de coelhos:");
    n = Int32.Parse(Console.ReadLine());
    
    custo = n * 32;
    
    Console.WriteLine("O custo total de criação é: " + custo);
  }
}
