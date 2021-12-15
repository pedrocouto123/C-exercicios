using System;
class HelloWorld {
  static void Main() {
     double tempo, distancia, velocidade;
     
     Console.WriteLine("Digite o tempo gasto:");
     tempo = double.Parse(Console.ReadLine());
     
     Console.WriteLine("Digite a distancia percorrida:");
     distancia = double.Parse(Console.ReadLine());
     
     velocidade = distancia / tempo;
     
     Console.WriteLine("A velocidade média é: " + velocidade);
    
  }
}
