using System;
class HelloWorld {
  static void Main() {
    double a;
    string op;
   Console.WriteLine("Digite um valor:");
   a = double.Parse(Console.ReadLine());
   
   Console.WriteLine("Deseja digitar outro valor?");
   op = Console.ReadLine();
   while(op != "nao"){
       Console.WriteLine("Digite um valor:");
        a = double.Parse(Console.ReadLine());
   
        Console.WriteLine("Deseja digitar outro valor?");
        op = Console.ReadLine();
   }
    
  }
}
