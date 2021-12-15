using System;
class HelloWorld {
  static void Main() {
    double nota1, nota2, media;
    
    Console.WriteLine("Digite uma nota:");
    nota1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite outra nota:");
    nota2 = double.Parse(Console.ReadLine());
    
    media = (nota1 + nota2) / 2;
    
    if(media >= 7){
        Console.WriteLine("Aprovado!!!");
    }
    else if(media < 7){
        Console.WriteLine("Reprovado!!!");
    }
  }
}
