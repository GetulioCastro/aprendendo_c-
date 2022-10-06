using System;

class Aula16 {
  static void Main () {

      int tempo=0;
      char escolha;

      // comando 'goto' não é muito usado, mas, é fundamento da linguagem C#
      inicio:
      Console.Clear();
      
      Console.WriteLine("Belo Horizonte/MG para Vitória/ES");
      Console.WriteLine("\nEscolha sua forma de viajar: [a] Avião | [c] Carro | [o] Ônibus ");

      escolha=char.Parse(Console.ReadLine());

      switch(escolha){
          case 'a':
          case 'A':
              tempo=50;
              break;
          case 'c':
          case 'C':
              tempo=480;
              break;
          case 'o':
          case 'O':
              tempo=660;
              break;
          default:
              tempo=-1;
              break;
    }
      
    // if(tempo<0){
    //     Console.WriteLine("Tempo indisponível!");
    // }else{
    //     Console.WriteLine("Devido o transporte escolhido, seu tempo de deslocamento é de {0} minutos.",tempo);
    // }
    double min=(tempo/60);
      
    if(tempo>60){
        Console.WriteLine("Devido o transporte escolhido, seu tempo de deslocamento é de {0} horas.",min);
    }else if(tempo<60){
        Console.WriteLine("Devido o transporte escolhido, seu tempo de deslocamento é de {0} minutos.",tempo);
    }else{
        Console.WriteLine("Tempo indisponível para esta escolha!");
    }
      
    Console.Write("\nCalcular outro transporte? ");
    escolha=char.Parse(Console.ReadLine());
    if(escolha=='s' || escolha=='S'){
        goto inicio;
    }else{
        Console.Clear();
        Console.WriteLine("Fim da execuçao do programa!");
    }
   
  }
}