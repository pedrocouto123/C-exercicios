using System;
class HelloWorld {
  static void Main() {
    double renda, ajuste;  
    Console.WriteLine("Digite a renda mensal:");
    renda = double.Parse(Console.ReadLine());
    
    ajuste = (renda * 10)/100;
    
    Console.WriteLine("O imposto de renda a ser pago é de " + ajuste);
  }
}
