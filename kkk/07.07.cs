using System;
class HelloWorld {
  static void Main() {
    int a1, r;
    int n;
    int cont = 0;
    Console.WriteLine("Digite o primeiro termo da PA:");
    a1 = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a razão da PA:");
    r = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o número de termos da PA:");
    n = Int32.Parse(Console.ReadLine());
    
    Console.Clear();
    
    Console.WriteLine("O primeiro termo da PA é: " + a1);
    Console.WriteLine("A razão da PA é: " + r);
    Console.WriteLine("A PA tem " + n + "termos");
    
    while(cont < n){
        a1 = a1 + r;
        Console.WriteLine("O termo é " + a1);
        cont = cont + 1;
    }
    
  }
}
