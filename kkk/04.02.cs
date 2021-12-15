using System;
class HelloWorld {
  static void Main() {
  double n1, n2, n3, n4, n5;
  
  Console.WriteLine("Digite o primeiro número:");
  n1 = double.Parse(Console.ReadLine());
  
  Console.WriteLine("Digite o segundo número:");
  n2 = double.Parse(Console.ReadLine());
  
  Console.WriteLine("Digite o terceiro número:");
  n3 = double.Parse(Console.ReadLine());
  
  Console.WriteLine("Digite o quarto número:");
  n4 = double.Parse(Console.ReadLine());
  
  Console.WriteLine("Digite o quinto número:");
  n5 = double.Parse(Console.ReadLine());
  
  /*Maior número*/
  if(n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5){
      Console.WriteLine("O primeiro número é o maior");
  }
  
  else if(n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5){
      Console.WriteLine("O segundo número é o maior");
  }
  
  else if(n3 > n2 && n3 > n1 && n3 > n4 && n3 > n5){
      Console.WriteLine("O terceiro número é o maior");
  }
  
  else if(n4 > n2 && n4 > n3 && n4 > n1 && n4 > n5){
      Console.WriteLine("O quarto número é o maior");
  }
  
  else if(n5 > n2 && n5 > n3 && n5 > n4 && n5 > n1){
      Console.WriteLine("O quinto número é o maior");
  }
  /*Maior número*/
  
  /*Menor número*/
  if(n1 < n2 && n1 < n3 && n1 < n4 && n1 < n5){
      Console.WriteLine("O primeiro número é o menor");
  }
  
  else if(n2 < n1 && n2 < n3 && n2 < n4 && n2 < n5){
      Console.WriteLine("O segundo número é o menor");
  }
  
  else if(n3 < n2 && n3 < n1 && n3 < n4 && n3 < n5){
      Console.WriteLine("O terceiro número é o menor");
  }
  
  else if(n4 < n2 && n4 < n3 && n4 < n1 && n4 < n5){
      Console.WriteLine("O quarto número é o menor");
  }
  
  else if(n5 < n2 && n5 < n3 && n5 < n4 && n5 < n1){
      Console.WriteLine("O quinto número é o menorr");
  }
  /*Menor número*/
  
  
  }
  
}
