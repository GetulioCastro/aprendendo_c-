using System;

class Aula08 {
    static void Main () {
        int v1,v2,soma;
        string nome;

        Console.Write("Qual seu nome? ");
        nome=Console.ReadLine();
        Console.Write("Digite um número: ");
        v1=int.Parse(Console.ReadLine());
        Console.Write("Digite outro número: ");
        v2=Convert.ToInt32(Console.ReadLine());
        soma=v1+v2;
        Console.WriteLine("{0} digitou dois números {1} e {2}. A soma deles é: {3}",nome,v1,v2,soma);
  }
}