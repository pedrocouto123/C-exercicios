using System;
class HelloWorld {
  static void Main() {
    int cont, a;
    
    a = 1;
    cont = 0;
    while(cont < 20){
        cont = a * a;
        Console.WriteLine(cont);
        a = a + 1;
    }
    
  }
}
