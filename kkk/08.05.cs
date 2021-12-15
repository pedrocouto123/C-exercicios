using System;
class HelloWorld {
  static void Main() {
    int cont = 0;
    int soma = 0;
    
    while(cont < 100){
        cont = cont + 1;
        soma = soma + cont;
    }
    Console.WriteLine(soma);
  }
}
