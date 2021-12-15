using System;
class HelloWorld {
  static void Main() {
    double a, b, c;  
    Console.WriteLine("1° valor:");
    a = double.Parse(Console.ReadLine());
    
    Console.WriteLine("2° valor:");
    b = double.Parse(Console.ReadLine());
    
    Console.WriteLine("3° valor:");
    c = double.Parse(Console.ReadLine());
    
    if(a > b && b > c){
        Console.WriteLine(a + " - maior valor");
        Console.WriteLine(b + " - medio valor");
        Console.WriteLine(c + " - menor valor");
    }
    else if(b > a && a > c){
        Console.WriteLine(b + " - maior valor");
        Console.WriteLine(a + " - medio valor");
        Console.WriteLine(c + " - menor valor");
    }
    else if(c > b && b > a){
        Console.WriteLine(c + " - maior valor");
        Console.WriteLine(b + " - medio valor");
        Console.WriteLine(a + " - menor valor");
    }
    else if(b > c && c > a){
        Console.WriteLine(b + " - maior valor");
        Console.WriteLine(c + " - medio valor");
        Console.WriteLine(a + " - menor valor");
    }
    
  }
}
