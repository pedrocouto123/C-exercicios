using System;
class HelloWorld {
  static void Main() {
    int a, tab;  
    int cont = 2;
    
    Console.WriteLine("Digite um número:");
    a = Int32.Parse(Console.ReadLine());
    
    while(cont < 11){
        
        tab = a * cont;
        Console.WriteLine(tab);
        cont = cont + 1;
    }
    
  }
}
