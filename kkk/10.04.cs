using System;
class HelloWorld {
  static void Main() {
    double n;
    int cont = 0;
    int a = 0;
    
    
    while(cont < 5){
        Console.WriteLine("Digite um valor:");
        n = double.Parse(Console.ReadLine());
        if(n < 0){
            a = a + 1;
        }
    
        cont = cont + 1;
        
    }
    Console.WriteLine("Quantidade de valores negativos:" + a);
  }
}
