using System;
class HelloWorld {
  static void Main() {
    double n, p;
    
    
    Console.WriteLine("Digite um número:");
    n = double.Parse(Console.ReadLine());
    
    if(n <= 50){
        p = n * 3;
        while(p < 250){
            Console.WriteLine(p);
            p = p * 3;
        }
    }
    
  }
}
