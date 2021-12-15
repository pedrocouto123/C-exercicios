using System;
class HelloWorld {
  static void Main() {
    int cont = 0;
    int a;
    int n;
    
    Console.WriteLine("Digite um valor:");
    n = Int32.Parse(Console.ReadLine());
    Console.Clear();
    
    while(cont < 10){
        cont = cont + 1;
        a = cont * n;
        Console.WriteLine(a);
    }
  }
}
