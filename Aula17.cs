using System;

class Aula17 {
  static void Main () {
    //int n1,n2,n3,n4,n5;
    int[] n=new int[5]; //0-4
    //int[] num=new int[3]{55,77,99};
    int[] num={55,77,99,66,88};
    string[] veiculos=new string[3];

    veiculos[0]="carro";
    veiculos[1]="moto";
    veiculos[2]="navio";

    n[0]=111;
    n[1]=222;
    n[2]=333;
    n[3]=444;
    n[4]=555;

    Console.WriteLine(n[0]);
    Console.WriteLine(num[2]);
  }
}