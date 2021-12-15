using System;
class HelloWorld {
  static void Main() {
    int cont = 0;
    double a = 0;
    double nota, media;
    int op;
    
    Console.WriteLine("Digite uma nota:");
    nota = double.Parse(Console.ReadLine());
    cont = cont + 1;
    Console.WriteLine("Deseja informar outra nota???");
    Console.WriteLine("1 - Sim");
    Console.WriteLine("2 - Não");
    op = Int32.Parse(Console.ReadLine());
    
    while(op != 2){
        Console.WriteLine("Digite uma nota:");
        nota = double.Parse(Console.ReadLine());
        cont = cont + 1;
        Console.WriteLine("Deseja informar outra nota???");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        op = Int32.Parse(Console.ReadLine());
        
        
    }
    media = nota / cont;
    
    Console.WriteLine("A média é: " + media);
    
  }
}
