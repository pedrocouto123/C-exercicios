using System;
class HelloWorld {
  static void Main() {
    string sexo;  
    Console.WriteLine("Digite seu sexo:");
    sexo = Console.ReadLine();
    
    if(sexo == "MASCULINO" && sexo == "Masculino" && sexo == "masculino"){
        Console.WriteLine("Sexo válido");
    }
    else{
        Console.WriteLine("Sexo inválido");
    }
  }
}
