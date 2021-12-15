using System;
class HelloWorld {
  static void Main() {
  int op;
  int cont = 0;
  int a = 0;
  int b = 0;
  
  while(cont < 500){
      Console.WriteLine("Sim ou Não???");
      Console.WriteLine("1 - Sim");
      Console.WriteLine("2 - Não");
      op = Int32.Parse(Console.ReadLine());
      
      
      if(op == 1){
          a = a + 1;
      }
      if(op == 2){
          b = b + 1;
      }
      
      cont = cont + 1;
      
      
      
  }
  Console.WriteLine("A quantidade de sim é: " + a);
  Console.WriteLine("A quantidade de não é: " + b);
  
  }
}
