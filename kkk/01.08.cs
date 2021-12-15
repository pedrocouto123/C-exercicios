using System;
class HelloWorld {
  static void Main() {
    double raio, volume;  
    Console.WriteLine("Digite o raio da esfera");
    raio = double.Parse(Console.ReadLine());
    
    volume = (4 * (3.14 * raio * raio * raio)) / 3;
    
    Console.WriteLine("O volume da esfera é: " + volume);
  }
  
}
