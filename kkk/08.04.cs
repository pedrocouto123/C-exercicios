using System;
class HelloWorld {
  static void Main() {
    double a;
    double cont = 1;
    double media;
    
    Console.WriteLine("Digite uma nota:");
    a = double.Parse(Console.ReadLine());
    while(cont <= 20){
        Console.WriteLine("Digite uma nota:");
        a = double.Parse(Console.ReadLine());
        cont = cont + 1;
        a = a + cont;
    }
    media = a / cont;
    Console.WriteLine("A média é: " + media);
  }
}
