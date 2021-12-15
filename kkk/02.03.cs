using System;
class HelloWorld {
  static void Main() {
    double raio, volume, altura;
    Console.WriteLine("Digite o raio da base:");
    raio = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a altura:");
    altura = double.Parse(Console.ReadLine());
    
    volume = (3.14 * raio * raio) * altura;
    
    Console.WriteLine("O volume da lata de oleo é: " + volume);
  }
}
