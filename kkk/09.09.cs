using System;
class HelloWorld {
  static void Main() {
    int cont = 0;
    int soma = 0;
    
    while(cont < 10){
        cont = cont + 1;
        soma = soma + cont;
        if(cont == 10){
            Console.WriteLine(soma);
        }
    }
  }
}
