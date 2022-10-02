using System;

class EscopoVariaveis {

    static int num=10; // escopo global, tipo de variavel referenciada pelo metodo
    
    static void Main () {
      int num2=0; // escopo local, so e acessada se nomeada/chamada
      Console.WriteLine (num);
    }
}