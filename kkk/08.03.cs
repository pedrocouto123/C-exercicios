using System;
class HelloWorld {
  static void Main() {
    double pop_a, pop_b;
    double taxa_a =  0.1;
    double taxa_b  = 0.2;
    int cont = 0;
    
      
    Console.WriteLine("Digite o tamanho da População A:");
    pop_a = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o tamanho da População B:");
    pop_b = double.Parse(Console.ReadLine());
    
    while(pop_a < pop_b){
        pop_a = pop_a + 2;
        pop_b = pop_b + 1;
        cont = cont + 1;
        if(pop_a == pop_b){
            Console.WriteLine("O tempo gasto é: " + cont + " anos");
        }
        
    }
    
  }
}
