using System;
class HelloWorld {
  static void Main() {
    double n;
    string op;
    
    Console.WriteLine("Digite um valor:");
    n = double.Parse(Console.ReadLine());
    
    Console.Clear();
    
    Console.WriteLine("Deseja continuar???");
    op = Console.ReadLine();
    
    while(op != "nao"){
        Console.WriteLine("Digite um valor:");
        n = double.Parse(Console.ReadLine());
    
        Console.Clear();
    
        Console.WriteLine("Deseja continuar???");
        op = Console.ReadLine();
    }
  }
}
