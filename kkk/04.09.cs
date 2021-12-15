using System;
class HelloWorld {
  static void Main() {
   double nota;
   
   Console.WriteLine("Digite sua nota:");
   nota = double.Parse(Console.ReadLine());
   
   if(nota >= 7){
       Console.WriteLine("Aprovado");
       Console.WriteLine("A sua nota é: " + nota);
   }
  }
}
