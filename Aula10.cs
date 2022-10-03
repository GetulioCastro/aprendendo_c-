using System;

class Aula10 {

  enum DiasSemana {Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
                  //  0       1      2      3      4     5      6 (índices)
    
  static void Main () {

    DiasSemana ds1=(DiasSemana)3; // converte índice em nome a partir do enum

    int ds2=(int)DiasSemana.Sexta; // converte nome em índice do enum
      
    Console.WriteLine (ds1);
    Console.WriteLine (ds2);
                      
  }
}