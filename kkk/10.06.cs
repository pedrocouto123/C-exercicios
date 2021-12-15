using System;
class HelloWorld {
  static void Main() {
    double pop_a = 1;
    double pop_b = 3;
    
    double taxa_a = 1;
    double taxa_b = 3;
    double a = 0;
    double b = 0;
    double cont = 0;
    
    
    
    a = pop_a + taxa_a;
    b = pop_b + taxa_b;
    
    while(a <= b){
        cont = cont + 1;
        if(a > b){
            Console.WriteLine("O tempo é " + cont);
        }
    }
  }
}
