using System;
class HelloWorld {
  static void Main() {
    double n, m;
    double cont = 0;
    Console.WriteLine("Digite um valor:");
    n = double.Parse(Console.ReadLine());
    
    while(cont < 10){
        cont = cont + 1;
        m = cont * n;
        Console.WriteLine(n + " x " + cont + " = " + m);
    }
  }
}
