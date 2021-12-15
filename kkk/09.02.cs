using System;
class HelloWorld {
  static void Main() {
    double cont = 1;
    double c;
    
    while(cont <= 5){
        c = Math.Pow(cont, 2);
        Console.WriteLine(c);
        cont = cont + 1;
        
    }
  }
}
