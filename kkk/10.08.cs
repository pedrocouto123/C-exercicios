using System;
class HelloWorld {
  static void Main() {
    double cont = 0;
    double nota, soma, media;
    
    
    while(cont < 3){
        Console.WriteLine("Digite uma nota:");
        nota = double.Parse(Console.ReadLine());
        soma = nota + cont;
        cont = cont + 1; 
        if(cont == 3){
            media = soma / cont;
            Console.WriteLine("A média é: " + media);
        }
    }
    
  }
}
