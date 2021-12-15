using System;
class HelloWorld {
  static void Main() {
    int cont = 0;
    
    while(cont < 10){
        cont = cont + 1;
        if(cont%2 != 0){
            Console.WriteLine(cont);
        }
    }
  }
}
