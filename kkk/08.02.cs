using System;
class HelloWorld {
  static void Main() {
    double idade, op;
    double cont = 1;
    double media;
    
    Console.WriteLine("Digite uma idade:");
    idade = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Deseja continuar???");
    Console.WriteLine("1 - Sim");
    Console.WriteLine("2 - Não");
    op = double.Parse(Console.ReadLine());
    Console.Clear();
    
    while(op != 2){
        cont = cont + 1;
        Console.WriteLine("Digite uma idade:");
        idade = double.Parse(Console.ReadLine());
        idade = idade + idade;
        Console.WriteLine("Deseja continuar???");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        op = double.Parse(Console.ReadLine());
        Console.Clear();
    }
    media = idade / cont;
    
    Console.WriteLine("Número de pessoas: " + cont);
    Console.WriteLine("Média das idades: " + media);
  }
}
