using System;

class Aula14 {
   static void Main () {
    int n1,n2,n3,n4,res;
    res=n1=n2=n3=n4=0;
    string resultado="Reprovado";

    Console.Write("Digite a nota 1: ");
    n1=int.Parse(Console.ReadLine());

    Console.Write("Digite a nota 2: ");
    n2=int.Parse(Console.ReadLine());

    Console.Write("Digite a nota 3: ");
    n3=int.Parse(Console.ReadLine());

    Console.Write("Digite a nota 4: ");
    n4=int.Parse(Console.ReadLine());

    res=(n1+n2+n3+n4);

    if (res >= 60){
        if (res >= 90){
            resultado="Aprovado com Louvor!";
        }else{
            resultado="Aprovado";
        }
    }else{
        if (res >= 40){
            resultado="Recuperação";
        }else{
            resultado="Reprovado";
        }
    }

    Console.WriteLine ("Nota: {0} -> Resultado: {1}", res,resultado);
  }
}