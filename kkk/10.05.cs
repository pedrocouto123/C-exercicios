using System;
class HelloWorld {
  static void Main() {
    double cont = 0;
    double idade;
    double media;
    double soma = 0;
    
    while(cont < 5){
        Console.WriteLine("Digite sua idade:");
        idade = double.Parse(Console.ReadLine());
        cont = cont + 1;
        soma = soma + idade;
        if(cont == 5){
            media = soma / cont;
            Console.WriteLine("A média das idades é: " + media);
        }
    }
  }
}
