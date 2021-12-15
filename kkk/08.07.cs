using System;
class HelloWorld {
  static void Main() {
  double cont = 0;
  double c;
  
  while(cont <= 15){
      c = Math.Pow(cont, 3);
      cont = cont + 1;
      Console.WriteLine(c);
  }
  
  }
}
