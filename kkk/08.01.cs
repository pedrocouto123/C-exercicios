using System;
class HelloWorld {
  static void Main() {
    int cont = 0;
    int a = 1;
    
    while(cont < 20){
        if(a%2 != 0){
           Console.WriteLine(a); 
        }
        
        a = a + 1;
        cont = cont + 1;
    }
  }
}
