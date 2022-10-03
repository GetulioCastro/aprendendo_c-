using System;

class Aula09 {
  static void Main () {

    int num_1=10;
    int num_2=10;

    num_1=num_1>>1; // bitwise à direita: diminui pela metade

    num_2=num_2<<1; // bitwise à esquerda: aumenta o dobro
      
    Console.WriteLine(num_1);

    Console.WriteLine(num_2);
  }
}