using System;
class HelloWorld {
  static void Main() {
    int cont = 0;
    double a, b, c, d, e;
    
    Console.WriteLine("Digite um número:");
    a = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite um número:");
    b = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite um número:");
    c = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite um número:");
    d = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite um número:");
    e = double.Parse(Console.ReadLine());
    
    if(a < 0){
        cont = cont + 1;
    }
    if(b < 0){
        cont = cont + 1;
    }
    if(c < 0){
        cont = cont + 1;
    }
    if(d < 0){
        cont = cont + 1;
    }
    if(e < 0){
        cont = cont + 1;
    }
    Console.WriteLine("A quantidade de valores negativos digitados são: " + cont);
  }
}
