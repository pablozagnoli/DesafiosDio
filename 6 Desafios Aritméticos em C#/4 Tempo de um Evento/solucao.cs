/*
 Desafio
    Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de 
 Abril, iniciando e terminando dentro do mês. O problema é que Pedrinho quer calcular o tempo 
 que o evento vai durar, uma vez que ele sabe quando inicia e quando termina o evento.

    Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho 
 a calcular a duração deste evento.

 Entrada
    Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um espaço e o dia do 
 mês no qual o evento vai começar. Na linha seguinte, será informado o momento no qual o evento vai 
 iniciar, no formato hh : mm : ss. Na terceira e quarta linha de entrada haverá outra informação no 
 mesmo formato das duas primeiras linhas, indicando o término do evento.

 Saída
    Na saída, deve ser apresentada a duração do evento, no seguinte formato:

 W dia(s)
 X hora(s)
 Y minuto(s)
 Z segundo(s)

    Obs: Considere que o evento do caso de teste para o problema tem duração mínima de 1 minuto.
*/

using System;

class TempoDeUmEvento
{
  static void Main(string[] args)
  {
    int vDiaInicio, vDiaTermino, vHoraMomentoInicio, vMinutoMomentoInicio, vSegundoMomentoInicio;
    int vHoraMomentoTermino, vMinutoMomentoTermino, vSegundoMomentoTerminio;

    string[] vDadosInicio = Console.ReadLine().Split(" ");
    vDiaInicio = Convert.ToInt32(vDadosInicio[1]);

    string[] vDadosMomentoInicio = Console.ReadLine().Split(":");
    vHoraMomentoInicio = Convert.ToInt32(vDadosMomentoInicio[0]);
    vMinutoMomentoInicio = Convert.ToInt32(vDadosMomentoInicio[1]);
    vSegundoMomentoInicio = Convert.ToInt32(vDadosMomentoInicio[2]);

    string[] vDadosTermino = Console.ReadLine().Split(" ");
    vDiaTermino = Convert.ToInt32(vDadosTermino[1]);

    string[] vDadosMomentoTermino = Console.ReadLine().Split(":");
    vHoraMomentoTermino = Convert.ToInt32(vDadosMomentoTermino[0]);
    vMinutoMomentoTermino = Convert.ToInt32(vDadosMomentoTermino[1]);
    vSegundoMomentoTerminio = Convert.ToInt32(vDadosMomentoTermino[2]);

    int vSegundo = (vSegundoMomentoTerminio - vSegundoMomentoInicio);
    int vMinuto = (vMinutoMomentoTermino - vMinutoMomentoInicio);
    int vHora = (vHoraMomentoTermino - vHoraMomentoInicio);
    int vDia = (vDiaTermino - vDiaInicio);

    if (vSegundo < 0)
    {
      vSegundo += 60;
      vMinuto--;
    }

    if (vMinuto < 0)
    {
      vMinuto += 60;
      vHora--;
    }

    if (vHora < 0)
    {
      vHora += 24;
      vDia--;
    }

    Console.WriteLine(vDia + " dia(s)");
    Console.WriteLine(vHora + " hora(s)");
    Console.WriteLine(vMinuto + " minuto(s)");
    Console.WriteLine(vSegundo + " segundo(s)");
  }
}