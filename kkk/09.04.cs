using System;
class HelloWorld {
  static void Main() {
    double cont = 0;
    double soma;
    double media;
    
    Console.WriteLine("Digite uma nota:");
    soma = double.Parse(Console.ReadLine());
    
    
    while(cont < 3){
        Console.WriteLine("Digite uma nota:");
        soma = double.Parse(Console.ReadLine());
        
        cont = cont + 1;
        soma = cont + soma;
        
    }
    media = soma / cont;
    Console.WriteLine("A média é: " + media);
  }
}
