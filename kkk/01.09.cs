using System;
class HelloWorld {
  static void Main() {
    int op;
    double c, f;
    Console.WriteLine("A temperatura está em Celsius ou Fahrenheit???");
    Console.WriteLine("1 - Celsius");
    Console.WriteLine("2 - Fahrenheit");
    op = Int32.Parse(Console.ReadLine());
    
    if(op == 1){
        Console.WriteLine("Okay, digite a temperatura em Celsius:");
        c = double.Parse(Console.ReadLine());
        f = (((9 * c) / 5) + 32);
        
        Console.WriteLine("A temperatura " + c + " em Celsius");
        Console.WriteLine("Corresponde a");
        Console.WriteLine(f + " em graus Fahrenheit");
    }
    else if(op == 2){
        Console.WriteLine("Okay, digite a temperatura em Fahrenheit:");
        f = double.Parse(Console.ReadLine());
        c = (5 * (f - 32)) / 9;
        
        Console.WriteLine("A temperatura " + f + " em Fahrenheit");
        Console.WriteLine("Corresponde a");
        Console.WriteLine(c + " em graus Celsius");
    }
    Console.WriteLine("Deseja calcular novamente???");
    Console.WriteLine("1 - Sim");
    Console.WriteLine("2 - Não");
    
    op = Int32.Parse(Console.ReadLine());
    
    while(op != 2){
        Console.WriteLine("A temperatura está em Celsius ou Fahrenheit???");
    Console.WriteLine("1 - Celsius");
    Console.WriteLine("2 - Fahrenheit");
    op = Int32.Parse(Console.ReadLine());
    
    if(op == 1){
        Console.WriteLine("Okay, digite a temperatura em Celsius:");
        c = double.Parse(Console.ReadLine());
        f = (((9 * c) / 5) + 32);
        
        Console.WriteLine("A temperatura " + c + " em Celsius");
        Console.WriteLine("Corresponde a");
        Console.WriteLine(f + " em graus Fahrenheit");
    }
    else if(op == 2){
        Console.WriteLine("Okay, digite a temperatura em Fahrenheit:");
        f = double.Parse(Console.ReadLine());
        c = (5 * (f - 32)) / 9;
        
        Console.WriteLine("A temperatura " + f + " em Fahrenheit");
        Console.WriteLine("Corresponde a");
        Console.WriteLine(c + " em graus Celsius");
    }
    Console.WriteLine("Deseja calcular novamente???");
    Console.WriteLine("1 - Sim");
    Console.WriteLine("2 - Não");
    
    op = Int32.Parse(Console.ReadLine());
    }
  }
  
}
