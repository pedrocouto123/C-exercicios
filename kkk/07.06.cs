using System;
class HelloWorld {
  static void Main() {
    int cont = 0;
    int a = 0;
    
    while(cont <= 100){
        
        if(a%11 == 5){
            Console.WriteLine(a);
        }
        a = a + 1;
        cont = cont + 1;
    }
  }
}
